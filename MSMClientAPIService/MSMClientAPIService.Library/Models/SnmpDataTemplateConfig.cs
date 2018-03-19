using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SnmpDataTemplateConfig
    {
        public long Id { get; set; }
        public string SnmpDataTemplateId { get; set; }
        public string SnmpOid { get; set; }
        public int ProtocolId { get; set; }
        public string Description { get; set; }
        public string SchdulerId { get; set; }
        public int Formatting { get; set; }
    }
}
