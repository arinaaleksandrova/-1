using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_312
{
   public class checkUser
    {
        public string Login { get; set; }

        public bool IsAdmin { get;  }

        public string Status => IsAdmin ? "Admin" : "User";

        public checkUser(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
