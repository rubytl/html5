using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SnmpDataTemplate
    {
        public string SnmpDataTemplateId { get; set; }
        public string MibFilesPackageId { get; set; }
        public string Name { get; set; }
    }
}
