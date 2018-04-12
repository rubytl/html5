using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class OccasionalNotification
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int ReportType { get; set; }
        public byte DataLogType { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime TimeStamp { get; set; }
        public byte? ReportFormat { get; set; }
        public int ActionType { get; set; }

        public Site Site { get; set; }
    }
}
