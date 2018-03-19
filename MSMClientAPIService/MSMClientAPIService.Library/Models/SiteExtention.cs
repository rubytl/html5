using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SiteExtention
    {
        public int SiteId { get; set; }
        public int? AxisX { get; set; }
        public int? AxisY { get; set; }
        public DateTime? InventoryDate { get; set; }
        public DateTime? LoadCurrentAvePeakReset { get; set; }

        public Site Site { get; set; }
    }
}
