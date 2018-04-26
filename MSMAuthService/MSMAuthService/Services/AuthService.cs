using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MSMAuthService.Helpers;
using MSMAuthService.Identity;
using MSMAuthService.Models;

namespace MSMAuthService.Services
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MSMAuthService.Services.IAuthService" />
    public class AuthService : IAuthService
    {
        /// <summary>
        /// The JWT factory
        /// </summary>
        private readonly IJwtFactory jwtFactory;
        /// <summary>
        /// The user manager
        /// </summary>
        private readonly UserManager<AppIdentityUser> userManager;
        /// <summary>
        /// The sign in manager
        /// </summary>
        private readonly SignInManager<AppIdentityUser> signInManager;

        /// <summary>
        /// The role manager
        /// </summary>
        private readonly RoleManager<AppIdentityRole> roleManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthService"/> class.
        /// </summary>
        /// <param name="jwtFactory">The JWT factory.</param>
        /// <param name="userManager">The user manager.</param>
        /// <param name="signInManager">The sign in manager.</param>
        public AuthService(IJwtFactory jwtFactory, UserManager<AppIdentityUser> userManager,
            SignInManager<AppIdentityUser> signInManager, RoleManager<AppIdentityRole> roleManager)
        {
            this.jwtFactory = jwtFactory;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        /// <summary>
        /// Logouts the specified token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async Task<bool> Logout(string token)
        {
            await this.signInManager.SignOutAsync();
            RefreshToken refreshToken = await this.GetExistingToken(token);
            await this.jwtFactory.RemoveRefreshToken(token);
            return await Task.FromResult(true);
        }

        /// <summary>
        /// Gets the existing token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        /// <exception cref="Exception">
        /// Existing token was not found.
        /// or
        /// Existing token was revoked
        /// </exception>
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

        /// <summary>
        /// Refreshes the access token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async Task<JwtResponse> RefreshAccessToken(string token)
        {
            RefreshToken refreshToken = await this.GetExistingToken(token);
            await this.jwtFactory.RemoveRefreshToken(token);
            return await this.jwtFactory.GenerateJwtToken(refreshToken.Username);
        }

        /// <summary>
        /// Revokes the refresh token.
        /// </summary>
        /// <param name="token">The token.</param>
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
            var userToVerify = await this.userManager.FindByNameAsync(userName);
            if (userToVerify == null)
            {
                return await Task.FromResult(new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotAllowd });
            }

            // check the credentials
            var pwToVerity = await this.signInManager.PasswordSignInAsync(userName, password, isPersistent: false, lockoutOnFailure: false);
            if (!pwToVerity.Succeeded)
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

        public async Task<bool> Register(RegisterModel model)
        {
            var user = new AppIdentityUser
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            var result = await this.userManager.CreateAsync(user, model.Password);
            return await Task.FromResult(result.Succeeded);
        }

        public async Task<bool> CreateNewRole(string roleName)
        {
            AppIdentityRole role = new AppIdentityRole();
            role.Name = roleName;
            role.Description = "Perform " + roleName +" operations.";
            IdentityResult roleResult = this.roleManager.CreateAsync(role).Result;
            return await Task.FromResult(roleResult.Succeeded);
        }

        public async Task<bool> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            var user = await this.userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return false;
            }

            if (!await this.userManager.IsEmailConfirmedAsync(user))
            {
                return false;
            }

            return await this.ResetPassword(new ResetPasswordModel() { Email = email});
        }

        public async Task<bool> ResetPassword(ResetPasswordModel model)
        {
            if (string.IsNullOrEmpty(model.Email))
            {
                return false;
            }

            var user = await this.userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return false;
            }

            model.Code = await this.userManager.GeneratePasswordResetTokenAsync(user);
            var result = await this.userManager.ResetPasswordAsync(user, model.Code, model.Password);
            return result.Succeeded;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CheckLoginResponse
    {
        /// <summary>
        /// Gets or sets the name of the machine.
        /// </summary>
        /// <value>
        /// The name of the machine.
        /// </value>
        public string MachineName { get; set; }
        /// <summary>
        /// Gets or sets the check login result.
        /// </summary>
        /// <value>
        /// The check login result.
        /// </value>
        public CheckLoginResult CheckLoginResult { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum CheckLoginResult
    {
        /// <summary>
        /// The allowed
        /// </summary>
        Allowed = 0,

        /// <summary>
        /// The already logged in
        /// </summary>
        AlreadyLoggedIn = 1,

        /// <summary>
        /// The not valid license
        /// </summary>
        NotValidLicense = 2,

        /// <summary>
        /// The user limit reached
        /// </summary>
        UserLimitReached = 3,

        /// <summary>
        /// The not allowd
        /// </summary>
        NotAllowd = 4
    }
}
