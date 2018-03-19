using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SnmpconfigTemplate
    {
        public SnmpconfigTemplate()
        {
            Site = new HashSet<Site>();
        }

        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public int SnmpVersion { get; set; }
        public int PortNumber { get; set; }
        public string ReadCommunityString { get; set; }
        public string SecurityName { get; set; }
        public int? AuthProtocol { get; set; }
        public int? PrivProtocol { get; set; }
        public string AuthKey { get; set; }
        public string PrivKey { get; set; }
        public int? SecurityLevel { get; set; }

        public ICollection<Site> Site { get; set; }
    }
}
