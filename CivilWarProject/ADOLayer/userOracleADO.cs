using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;


//https://msdn.microsoft.com/en-us/library/dw70f090(v=vs.110).aspx

namespace CivilWarProject.ADOLayer
{
    class userOracleADO : userADO
    {
        OracleConnection connection = new OracleConnection(DBConnection.CONNECT);

        public int assignUserID()
        {
            int nextId;
            String sql = "SELECT (MAX)UserId FROM User";

            using (connection)
            {
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
        }
        public void userADO.createUser(int id, string username, string password, string email)
        {
            String sql = "INSERT INTO user VALUES (" + id + ",'" + username + "','" + password + "','" + email + ")";

            using (connection)
            {
                OracleCommand
            }
        }
    }
}
