using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMClientAPIService.Enums
{
    /// <summary>
    /// The result enumeration of CanAddSite invoke
    /// </summary>
    public enum AddSiteResult
    {
        /// <summary>
        /// The XML configuration file
        /// </summary>
        LimitExceeded = 1,

        /// <summary>
        /// The firmware file
        /// </summary>
        LicenseInvalid = 2,

        /// <summary>
        /// The picture file
        /// </summary>
        LicenseExpired = 3,

        /// <summary>
        /// The report file
        /// </summary>
        Ok = 4,

        /// <summary>
        /// The failed to check
        /// </summary>
        FailedToCheck
    }
}
