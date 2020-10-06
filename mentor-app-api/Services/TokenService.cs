using mentor_app_api.Entities;
using mentor_app_api.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mentor_app_api.Services
{
    public class TokenService : ITokenService
    {
        
        public TokenService(IConfiguration config)
        {
        }

        public string CreateToken(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
