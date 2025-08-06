using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class Admin : Employee
    {
        public Admin(string userName, string userPassword, string userMail) : base(userName, userPassword, userMail)
        {
        }
    }
}
