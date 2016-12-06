using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CivilWarProject
{
    interface userADO
    {

        int assignUserID();

        void createUser(int id, String username, String password, String email);

        bool nameAvailable(String username);

        bool logIn(String username, String password);

    }
}
