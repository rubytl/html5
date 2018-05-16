using System;
using System.Threading.Tasks;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Enums;
using MSMClientAPIService.Helpers;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Services
{
    public class AuthService : IAuthService
    {
        private readonly IJwtFactory jwtFactory;

        private readonly IUserMaintenanceRepository userRepo;

        public AuthService(IJwtFactory jwtFactory, IUserMaintenanceRepository userRepo)
        {
            this.jwtFactory = jwtFactory;
            this.userRepo = userRepo;
        }

        public async Task<bool> Logout(string token)
        {
            RefreshToken refreshToken = await this.GetExistingToken(token);
            await this.jwtFactory.RemoveRefreshToken(token);
            return await Task.FromResult(true);
        }

        private async Task<RefreshToken> GetExistingToken(string token)
        {
            RefreshToken refreshToken = await this.jwtFactory.GetRefreshToken(token);
            if (refreshToken == null)
            {
                throw new Exception("Existing token was not found.");
            }

            if (refreshToken.Revoked)
            {
                throw new Exception("Existing token was revoked");
            }

            return await Task.FromResult(refreshToken);
        }

        public async Task<JwtResponse> RefreshAccessToken(string token)
        {
            RefreshToken refreshToken = await this.GetExistingToken(token);
            await this.jwtFactory.RemoveRefreshToken(token);
            return await this.jwtFactory.GenerateJwtToken(refreshToken.Username);
        }

        public async void RevokeRefreshToken(string token)
        {
            RefreshToken refreshToken = await this.GetExistingToken(token);
            refreshToken.Revoked = true;
        }

        /// <summary>
        /// Checks the login.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<CheckLoginResponse> CheckLogin(string userName, string password)
        {
            // check user's information
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return await Task.FromResult(new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotAllowd });
            }

            //get the user to verifty
            var userToVerify = await this.userRepo.GetSingleAsync(s => s.Username == userName);
            if (userToVerify == null)
            {
                return await Task.FromResult(new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotAllowd });
            }

            // check the credentials
            if (await this.userRepo.GetSingleAsync(s => s.Password == password) == null)
            {
                return await Task.FromResult(new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotAllowd });
            }

            //check license
            //if (!LoginHelper.LicenseStatusOK)
            //{
            //    return new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotValidLicense };
            //}

            //// check logged in already
            //if (LoginHelper.IsUserOnline(userName))
            //{
            //    string sessionID = string.Empty;

            //    if (LoginHelper.IsAlreadyLoggedIn(userName, sessionID))
            //    {
            //        return new CheckLoginResponse { CheckLoginResult = CheckLoginResult.AlreadyLoggedIn, MachineName = LoginHelper.GetUserHostName(userName) };
            //    }
            //    else
            //    {
            //        return new CheckLoginResponse { CheckLoginResult = CheckLoginResult.Allowed };
            //    }
            //}
            //else
            //{
            //    if (LoginHelper.ActiveUsers < LoginHelper.NumberOfClients)
            //    {
            //        return new CheckLoginResponse { CheckLoginResult = CheckLoginResult.Allowed };
            //    }
            //    else
            //    {
            //        return new CheckLoginResponse { CheckLoginResult = CheckLoginResult.UserLimitReached };
            //    }
            //}

            return new CheckLoginResponse { CheckLoginResult = CheckLoginResult.Allowed };
        }
    }
}
