using mentor_app_api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentor_app_api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
