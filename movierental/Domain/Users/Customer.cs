using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class Customer : User
    {
        public Customer(string UserName, string UserPassword, string UserMail) : base(UserName, UserPassword, UserMail)
        {
        }
    }
}
