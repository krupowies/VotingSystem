using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    class User
    {
        string userName;
        string password;
        int id;
        Role role;

        public User(string userName,string password, Role role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public User()
        {
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        internal Role Role { get => role; set => role = value; }
    }
}
