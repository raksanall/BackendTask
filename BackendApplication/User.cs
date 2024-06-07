using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public User(string name,string password) {

            Name = name;
            Password = password;

        }

    }
}
