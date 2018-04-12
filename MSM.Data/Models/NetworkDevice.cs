using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class NetworkDevice
    {
        public int Id { get; set; }
        public string Macaddress { get; set; }
        public string Ipaddress { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string UnitType { get; set; }
        public string Swversion { get; set; }
        public DateTime Swdate { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool UseTls12 { get; set; }
    }
}
