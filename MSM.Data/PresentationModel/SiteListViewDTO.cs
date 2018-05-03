using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSM.Data.PresentationModel
{
    public class SiteListViewDTO
    {
        #region Properties

        /// <summary>
        /// Gets or sets the site identifier.
        /// </summary>
        /// <value>
        /// The site identifier.
        /// </value>
        [Key]
        public int SiteID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the controller.
        /// </summary>
        /// <value>
        /// The type of the controller.
        /// </value>
        public int? ControllerType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>
        /// The ip address.
        /// </value>
        public string IPAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of alarm.
        /// </summary>
        /// <value>
        /// The number of alarm.
        /// </value>
        public int NoAlarm
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of waring.
        /// </summary>
        /// <value>
        /// The number of warning.
        /// </value>
        public int NoWarning
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number of offline.
        /// </summary>
        /// <value>
        /// The number of offline.
        /// </value>
        public int NoOffline
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last polling.
        /// </summary>
        /// <value>
        /// The last polling.
        /// </value>
        public DateTime LastPolling
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the site.
        /// </summary>
        /// <value>
        /// The name of the site.
        /// </value>
        public string SiteName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the offline status.
        /// </summary>
        /// <value>
        /// The offline status.
        /// </value>
        public string OfflineStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Main phase 1
        /// </summary>
        /// <returns></returns>
        public string MainPhase1 { get; set; }

        /// <summary>
        /// gets or sets rectifier current
        /// </summary>
        public string RectifierCurrent { get; set; }

        /// <summary>
        /// gets or sets battery voltage
        /// </summary>
        public string BatteryVoltage { get; set; }
        /// <summary>
        /// gets or sets load current
        /// </summary>
        public string LoadCurrent { get; set; }

        /// <summary>
        /// gets or sets battery temperature
        /// </summary>
        public string BatteryTemperature { get; set; }

        /// <summary>
        /// gets or sets solar current
        /// </summary>
        public string SolarCurrent { get; set; }

        #endregion Properties
    }
}
