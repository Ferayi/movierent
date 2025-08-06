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

        protected User(string userName, string userPassword, string userMail)
        {
            this.UserID = Guid.NewGuid();
            UserName = userName;
            UserPassword = userPassword;
            UserMail = userMail;
        }
      



        


        }
}
