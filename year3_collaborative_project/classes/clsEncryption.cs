using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CollaborativeProjectUnitTesting")]

namespace year3_collaborative_project.classes
{
    using BCrypt = BCrypt.Net.BCrypt;
    class clsEncryption
    {
        public string EncryptPassword(string sInputtedPassword)
        {           
            //Return encrypted sInputtedPassword
            return BCrypt.HashPassword(sInputtedPassword);
        }
    }
}
