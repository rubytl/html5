using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Helpers
{
    public interface IJwtFactory
    {
        Task<JwtResponse> GenerateJwtToken(string username);

        Task<RefreshToken> GetRefreshToken(string token);

        Task<bool> RemoveRefreshToken(string token);

        Task<ClaimsPrincipal> GetPrincipal(string token);
    }
}
