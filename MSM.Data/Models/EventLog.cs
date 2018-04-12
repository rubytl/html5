using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class EventLog
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int EventType { get; set; }
        public int EventSourceId { get; set; }
        public int? SiteId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Sender { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
    }
}
