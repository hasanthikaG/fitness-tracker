using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace fitness_tracker
{
    public class User
    {
        private string fName;
        private string lName;
        private string email;
        private string password;
        private int userId;
      
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }

        }

        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public string Password
        {
            get { return password; }
            set { password = value; }

        }

        public int UserId
        {
            get { return userId; }  
            set { userId = value; }
        }

    }
}
