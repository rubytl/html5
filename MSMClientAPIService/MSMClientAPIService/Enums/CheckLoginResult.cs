using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMClientAPIService.Enums
{
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
