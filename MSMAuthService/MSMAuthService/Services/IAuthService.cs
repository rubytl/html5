namespace MSMAuthService.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using MSMAuthService.Identity;
    using MSMAuthService.Models;

    /// <summary>
    /// 
    /// </summary>
    public interface IAuthService
    {
        #region Methods

        /// <summary>
        /// Checks the login.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<CheckLoginResponse> CheckLogin(string userName, string password);

        /// <summary>
        /// Creates the new role.
        /// </summary>
        /// <param name="roleName">Name of the role.</param>
        /// <returns></returns>
        Task<bool> CreateNewRole(string roleName);

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns></returns>
        IQueryable<AppIdentityUser> GetUsers(int pageIndex, int pageSize);

        /// <summary>
        /// Gets the roles.
        /// </summary>
        /// <returns></returns>
        IQueryable<AppIdentityRole> GetRoles();

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<bool> ForgotPassword(string email);

        /// <summary>
        /// Logouts the specified token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<bool> Logout(string token);

        /// <summary>
        /// Refreshes the access token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<JwtResponse> RefreshAccessToken(string token);

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task<object> CreateNewUser(RegisterModel model);

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        Task<bool> ResetPassword(ResetPasswordModel model);

        /// <summary>
        /// Revokes the refresh token.
        /// </summary>
        /// <param name="token">The token.</param>
        void RevokeRefreshToken(string token);

        Task<IdentityResult> DeleteUserById(string userId);

        Task<bool> UnlockUser(List<string> userIds);

        Task<bool> UpdateLastLogin(string userName);

        Task<bool> UpdateUsers(List<RegisterModel> userModels);

        #endregion Methods
    }
}