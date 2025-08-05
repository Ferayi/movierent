using Domain.Enums;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IJW_TokenGenerator
    {
        string GenerateToken(User user,UserRoleEnum role);
    }

}
