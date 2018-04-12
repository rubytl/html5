using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class Snmpreceiver
    {
        public long SnmptrapId { get; set; }
        public string TrapOid { get; set; }
        public string Ipaddress { get; set; }
        public string AlarmDescription { get; set; }
        public int Value { get; set; }
        public string MibreferenceStatus { get; set; }
        public string MibreferenceValue { get; set; }
        public int EventType { get; set; }
        public bool OnOffStatus { get; set; }
        public int RepeatCount { get; set; }
        public DateTime ReceiveTime { get; set; }
        public int TimeStamp { get; set; }
        public int Snmpversion { get; set; }
    }
}
