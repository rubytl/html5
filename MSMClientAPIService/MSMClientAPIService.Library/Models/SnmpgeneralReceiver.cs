using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SnmpgeneralReceiver
    {
        public long SnmptrapId { get; set; }
        public string TrapOid { get; set; }
        public string Ipaddress { get; set; }
        public DateTime ReceiveTime { get; set; }
        public int TimeStamp { get; set; }
        public int Snmpversion { get; set; }
        public string TrapCommunity { get; set; }
        public string FullMessageText { get; set; }
    }
}
