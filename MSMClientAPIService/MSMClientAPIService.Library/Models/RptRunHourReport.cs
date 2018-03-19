using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class RptRunHourReport
    {
        public int SiteId { get; set; }
        public string Description { get; set; }
        public int DataSiteId { get; set; }
        public string DataSiteDescription { get; set; }
        public int Idx { get; set; }
        public DateTime TimeFrame { get; set; }
        public string Path { get; set; }
        public int? Grid { get; set; }
        public int? Generator { get; set; }
        public int? Battery { get; set; }
    }
}
