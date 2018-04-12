using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class SiteInventory
    {
        public int SiteId { get; set; }
        public byte ModuleId { get; set; }
        public string ModuleType { get; set; }
        public byte? ModuleClassification { get; set; }
        public string PartName { get; set; }
        public byte? PartIndex { get; set; }
        public string PartNumber { get; set; }
        public string SerialNumber { get; set; }
        public string PartVersion { get; set; }
        public string SwpartNumber { get; set; }
        public string Swversion { get; set; }
        public string Manufactor { get; set; }
        public int? Capacity { get; set; }
        public short? Warranty { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public short Status { get; set; }

        public Site Site { get; set; }
    }
}
