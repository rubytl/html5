using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using MSMClientAPIService.Data.Helpers;
using Microsoft.AspNetCore.Identity;
using MSMClientAPIService.Data.Models;
using System.Threading.Tasks;
using MSMClientAPIService.Data.Repositories.Interfaces;

namespace MSMClientAPIService.Data.Repositories
{
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

    /// <summary>
    /// The UserMaintenanceRepository class
    /// </summary>
    /// <seealso cref="MSMClientAPIService.Data.EntityBaseRepository{MSMClientAPIService.Data.Models.Msmuser}" />
    /// <seealso cref="MSMClientAPIService.Data.Repositories.Interfaces.IUserMaintenanceRepository" />
    public class UserMaintenanceRepository : EntityBaseRepository<Msmuser>, IUserMaintenanceRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMaintenanceRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UserMaintenanceRepository(MultisiteDBEntitiesContext context)
            : base(context)
        { }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public async Task<bool> GetUser(string userName)
        {
            if (this.GetSingle(s => s.Username == userName) != null)
            {
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
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

            // get the user to verifty
            var userToVerify = await this.GetSingle(s => s.Username == userName);
            if (userToVerify == null)
            {
                return await Task.FromResult(new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotAllowd });
            }

            // check the credentials
            if (await this.GetSingle(s => s.Password == password) == null)
            {
                return await Task.FromResult(new CheckLoginResponse { CheckLoginResult = CheckLoginResult.NotAllowd });
            }

            // check license
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
