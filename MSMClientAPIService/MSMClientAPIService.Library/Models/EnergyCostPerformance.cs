using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class EnergyCostPerformance
    {
        public int SiteId { get; set; }
        public int? GridEnergyTotal { get; set; }
        public int? GenEnergyTotal { get; set; }
        public int? SolarEnergyTotal { get; set; }
        public int? WindEnergyTotal { get; set; }
        public decimal? SolarPrice { get; set; }
        public decimal? WindPrice { get; set; }
        public decimal? GridPrice { get; set; }
        public decimal? DieselPrice { get; set; }
        public DateTime? StatusTimeStamp { get; set; }
        public byte? Upflag { get; set; }

        public Site Site { get; set; }
    }
}
