using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;


//https://msdn.microsoft.com/en-us/library/dw70f090(v=vs.110).aspx

namespace CivilWarProject
{
    class userOracleADO : userADO
    {
        OracleConnection connection = new OracleConnection(DBConnection.CONNECT);

        public int assignUserID()
        {
            int nextId;
            String sql = "SELECT MAX(UserId) FROM userAccount";

            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Connection = connection;

            connection.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            //if (reader == null)
            nextId = 1;
            //else
            //    nextId = Convert.ToInt16(reader.GetValue(0)) + 1;

            connection.Close();
            return nextId;
        }

        public void createUser(int id, string username, string password, string email)
        {
            String sql = "INSERT INTO userAccount VALUES (" + 4 + ",'" + username + "','" + password + "','" + email + "')";

                OracleCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

            //try
            //{
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            //}

            //catch (Exception x)
            //{
            //    Console.WriteLine("There was error! could not create user");
            //}
        }


        /* http://stackoverflow.com/questions/3940587/calling-oracle-stored-procedure-from-c
         * Author: Abdul
         * Acces Date: 30/11/16
         */
        public bool nameAvailable(String username)
        {
            Int16 available=0;
            bool isAvailable = false;

            OracleCommand cmd = new OracleCommand("ValidateUsername", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Adding Paramters
            cmd.Parameters.Add("desiredName", username);

            // Adding return parameter
            cmd.Parameters.Add("validName", OracleDbType.Int16, available, ParameterDirection.Output);

            //Runing the procedure
            connection.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            available = reader.GetInt16(0);

            connection.Close();

            if (available == 1)
                isAvailable = true;
            else
                isAvailable = false;

            return isAvailable;
        }

        public bool logIn(String username, String password)
        {
            int valid =0;
            bool validCreds;

            OracleCommand cmd = new OracleCommand("ValidateLogin", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Adding Paremeters
            cmd.Parameters.Add("usernameEntered", username);
            cmd.Parameters.Add("passwordEntered", password);

            //Adding return retrun paremeters
            cmd.Parameters.Add("succesfullLogin", OracleDbType.Int16, valid, ParameterDirection.Output);

            //Running the procedure
            connection.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            valid = reader.GetInt16(0);

            connection.Close();

            if (valid == 1)
                validCreds = true;
            else
                validCreds = false;

            return validCreds;
        }

        //public int getNextUserID()
        //{

        //    int intNextID;

        //    myConn.Open();

        //    OracleCommand cmd = new OracleCommand("USER_ID", myConn);


        //    cmd.CommandType = CommandType.StoredProcedure;


        //    cmd.Parameters.Add("USERID", OracleDbType.Int32).Direction = ParameterDirection.Output;


        //    cmd.ExecuteNonQuery();


        //    intNextID = Convert.ToInt32(cmd.Parameters["USERID"].Value.ToString());



        //    //    myConn.Open();


        //    //OracleDataReader dr = cmd.ExecuteReader();
        //    //dr.Read();


        //    //if (dr.IsDBNull(0))
        //    //    intNextID = 1;
        //    //else
        //    //    intNextID = Convert.ToInt16(dr.GetValue(0)) + 1;


        //    myConn.Close();
        //    return intNextID++;


        //} //end getUserID


        public DataSet leaderBoardScore()
        {
            String strSQL = "SELECT username, noGamesWon FROM userAccount WHERE rownum <= 10 ORDER BY noGamesWon DESC";

            OracleCommand cmd = new OracleCommand(strSQL, connection);

            connection.Open();

            // Create an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();




            da.Fill(ds, "UserAccount");
            connection.Close();

            return ds;
        }


        public DataSet leaderBoardName()
        {
            String strSQL = "SELECT username, noGamesWon FROM userAccount WHERE rownum <= 10 ORDER BY username DESC";

            OracleCommand cmd = new OracleCommand(strSQL, connection);

            connection.Open();

            // Create an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();




            da.Fill(ds, "UserAccount");
            connection.Close();

            return ds;
        }

    } // End class
} // End namespace
