using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year3_collaborative_project.classes
{
    class clsUser
    {
        private static bool _bLoggedIn;
        private static int _iAccessLevel;
        private static string _sUsername;
        private static string _sPassword;
        private static int _iUserID;

        public static int AccessLevel { get => _iAccessLevel; set => _iAccessLevel = value; }
        public static string Username { get => _sUsername; set => _sUsername = value; }
        public static string Password { get => _sPassword; set => _sPassword = value; }
        public static int IUserID { get => _iUserID; set => _iUserID = value; }
        public static bool BLoggedIn { get => _bLoggedIn; set => _bLoggedIn = value; }
    }
}
