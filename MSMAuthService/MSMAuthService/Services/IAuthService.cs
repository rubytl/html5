using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSMAuthService.Models;

namespace MSMAuthService.Services
{
    public interface IAuthService
    {
        Task<bool> Logout(string token);

        Task<CheckLoginResponse> CheckLogin(string userName, string password);

        Task<JwtResponse> RefreshAccessToken(string token);

        void RevokeRefreshToken(string token);

        Task<bool> Register(RegisterModel model);
        Task<bool> ForgotPassword(string email);
        Task<bool> ResetPassword(ResetPasswordModel model);
    }
}
