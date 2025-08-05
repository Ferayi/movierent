using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public abstract class User
    {

        public Guid UserID { get; protected set; }
        public string UserName { get; protected set; }
        public string UserPassword { get; protected set; }
        public string UserMail { get; protected set; }

        protected User(string UserName, string UserPassword, string UserMail)
        {
            this.UserID = Guid.NewGuid();
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserMail = UserMail;
        }
      



        


        }
}
