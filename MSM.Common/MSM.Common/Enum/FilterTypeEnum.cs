using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MSMEnumerations
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterTypeEnum
    {
        /// <summary>
        /// All
        /// </summary>
        [Description("All")]
        all = 0,

        /// <summary>
        /// In Alarm
        /// </summary>
        [Description("In Alarm")]
        hasAlarm = 1,

        /// <summary>
        /// The is offline
        /// </summary>
        [Description("Is Offline")]
        isOffline = 2,

        /// <summary>
        /// All - Generator installed
        /// </summary>
        [Description("All - Generator installed")]
        hasGenerator = 3,

        /// <summary>
        /// All - PV installed
        /// </summary>
        [Description("All - PV installed")]
        hasSolar = 4,

        /// <summary>
        /// All - Wind turbine installed
        /// </summary>
        [Description("All - Wind turbine installed")]
        hasWind = 5,

        /// <summary>
        /// The hybrid
        /// </summary>
        [Description("Hybrid")]
        hybrid = 6,

        /// <summary>
        /// Hybrid - Generator installed
        /// </summary>
        [Description("Hybrid - Generator installed")]
        hybridGen = 7,

        /// <summary>
        /// Hybrid - PV installed
        /// </summary>
        [Description("Hybrid - PV installed")]
        hybridPV = 8,

        /// <summary>
        /// Hybrid - Wind turbine installed
        /// </summary>
        [Description("Hybrid - Wind turbine installed")]
        hybridWind = 9,

        /// <summary>
        /// Hybrid - AC monitoring
        /// </summary>
        [Description("Hybrid - AC monitoring")]
        hasMainsMonitorHybrid = 10,

        /// <summary>
        /// The on grid
        /// </summary>
        [Description("On grid")]
        onGrid = 11,

        /// <summary>
        /// On grid - Generator installed
        /// </summary>
        [Description("On grid - Generator installed")]
        onGridGen = 12,

        /// <summary>
        /// On grid - PV installed
        /// </summary>
        [Description("On grid - PV installed")]
        onGridPV = 13,

        /// <summary>
        /// On grid - Wind turbine installed
        /// </summary>
        [Description("On grid - Wind turbine installed")]
        onGridWind = 14,

        /// <summary>
        /// On grid - AC monitoring
        /// </summary>
        [Description("On grid - AC monitoring")]
        hasMainsMonitorGrid = 15,
    }
}