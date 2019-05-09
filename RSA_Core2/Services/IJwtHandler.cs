using Microsoft.IdentityModel.Tokens;
using RSA_Core2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSA_Core2.Services
{
    public interface IJwtHandler
    {
        JWT Create(string userId);
        TokenValidationParameters Parameters { get; }
    }
}
