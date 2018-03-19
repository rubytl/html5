using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class ProtocolDefinition
    {
        public int ProtocolId { get; set; }
        public string Description { get; set; }
        public int DbType { get; set; }
    }
}
