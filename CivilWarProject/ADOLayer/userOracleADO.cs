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

                try
                {
                    connection.Open();

                    OracleDataReader reader = cmd.ExecuteReader();

                    nextId = Convert.ToInt16(reader.GetValue(0));
                }

                catch (Exception x)
                {
                    nextId = 01;
                }

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

            isAvailable = reader.GetBoolean(0);

            return isAvailable;
        }

        public bool logIn(String username, String password)
        {
            bool validCreds;

            OracleCommand cmd = new OracleCommand("ValidateLogin", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Adding Paremeters
            cmd.Parameters.Add("usernameEntered", username);
            cmd.Parameters.Add("passwordEntered", password);

            //Running the procedure
            connection.Open();

            OracleDataReader reader = cmd.ExecuteReader();

            validCreds = reader.GetBoolean(0);

            return validCreds;
        }
    }
}
