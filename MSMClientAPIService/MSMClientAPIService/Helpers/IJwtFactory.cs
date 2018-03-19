using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MSMClientAPIService.Helpers
{
    public interface IJwtFactory
    {
        Task<string> GenerateJwtToken(string username);
        Task<ClaimsPrincipal> GetPrincipal(string token);
    }
}
