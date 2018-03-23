using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Services
{
    public interface IAuthService
    {
        Task<CheckLoginResponse> CheckLogin(string userName, string password);

        Task<JwtResponse> RefreshAccessToken(string token);

        void RevokeRefreshToken(string token);
    }
}
