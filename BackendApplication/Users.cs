using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication
{

    public class Users
    {
        
        private User[] users { get; set; }
        public User[] Userslist { get => users; }


        public Users()
        {

            users = new User[0];

        }

        public void UserAdd(User user)
        {

            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;

        }
    }
}