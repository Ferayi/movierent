using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces_Application_
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(string user_mail,string user_name, string user_password, UserRoleEnum role);
        Task<string> LoginAsync(string user_mail, string user_password);
    }
}
