using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class Employee : User
    {
        public Employee(string UserName, string UserPassword, string UserMail) : base(UserName, UserPassword, UserMail)
        {
        }
    }
}
