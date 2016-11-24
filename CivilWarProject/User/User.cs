using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilWarProject.User
{
    class User
    {
        private ADOLayer.userOracleADO userFactory = new ADOLayer.userOracleADO();

        private int userId;
        private String username;
        private String password;
        private String email;

        #region properties
        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        
        #endregion

        public User(String username, String password, String email)
        {
            UserId = userFactory.assignUserID();
            Username = username;
            Password = password;
            Email = email;

            userFactory.c
        }
    }
}
