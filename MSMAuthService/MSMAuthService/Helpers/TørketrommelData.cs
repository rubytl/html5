// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Eltek AS" file="TørketrommelData.cs">
// //   (c) Copyright 2010-2014 Eltek AS
// // </copyright>
// // <summary>
// //   MultisiteMonitor.Web, TørketrommelData.cs
// //   $Revision: 3$
// //   $Author: toma$
// //   $Date: 3. september 2013 14:05:28$
// //   $Modtime: 3. september 2013 14:05:28$
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Tørketrommel
{
    #region Using directives

    using System;

    #endregion

    [Serializable]
    public class TørketrommelData
    {
        
        public string ProductSerial { get; set; }

        public int NumberOfClients { get; set; }

        public int NumberOfSites { get; set; }

        public Boolean Valid { get; set; }

        public DateTime Expires { get; set; }
        public int NumberOfTrialDays { get; set; }

        public DateTime StartDate { get; set; }

        public string HWSerial { get; set; }

        public string MACAddress { get; set; }
        public string User { get; set; }
        public string Workstation { get; set; }
        public string Product { get; set; }
        public string ProductVersion { get; set; }
        public string ProductBuild { get; set; }
        public string Customer { get; set; }
        public string IPAddress { get; set; }
        public string OS { get; set; }
        public string MasterPass { get; set; }
        public string NTPServer { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// Bios info
        /// </summary>
        public string Spare1 { get; set; }
        /// <summary>
        /// list containing all available mac addresses on pc/server 
        /// </summary>
        public string Spare2 { get; set; }
        public string Spare3 { get; set; }
        public string Spare4 { get; set; }
    }
}
