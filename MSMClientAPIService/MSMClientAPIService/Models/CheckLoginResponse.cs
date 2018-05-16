using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSMClientAPIService.Enums;

namespace MSMClientAPIService.Models
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
}
