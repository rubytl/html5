using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class BatteryMaintenance
    {
        public int SiteId { get; set; }
        public int? InstalledBatteryCapacity { get; set; }
        public decimal? LoadCurrentAvg { get; set; }
        public decimal? LoadCurrentPeak { get; set; }
        public int? InstalledBatteryBackupOnAvg { get; set; }
        public int? InstalledBatteryBackupOnPeak { get; set; }
        public int? InstalledBatteryBackupTarget { get; set; }
        public byte? InstalledBatteryBackupOnAvgStatus { get; set; }
        public byte? InstalledBatteryBackupOnPeakStatus { get; set; }
        public DateTime? InstalledBatteryBackupStatusTimeStamp { get; set; }
        public byte? Upflag { get; set; }

        public Site Site { get; set; }
    }
}
