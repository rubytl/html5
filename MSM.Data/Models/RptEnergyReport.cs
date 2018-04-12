using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class RptEnergyReport
    {
        public int SiteId { get; set; }
        public int Id { get; set; }
        public int? Solar { get; set; }
        public int? Wind { get; set; }
        public int? Generator { get; set; }
        public int? Acinput { get; set; }
        public int? MainsMonitor { get; set; }
        public int? LoadEnergy1 { get; set; }
        public int? LoadEnergy2 { get; set; }
        public int? LoadEnergy3 { get; set; }
        public int? LoadEnergy4 { get; set; }
        public int? LoadEnergy5 { get; set; }
        public int? LoadEnergy6 { get; set; }
        public int? LoadEnergy7 { get; set; }
        public int? LoadEnergy8 { get; set; }
        public DateTime? TimeFrame { get; set; }
        public string Path { get; set; }
    }
}
