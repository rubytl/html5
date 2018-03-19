using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class ControllerType
    {
        public int ControllerTypeId { get; set; }
        public string ControllerTypeName { get; set; }
        public int VendorId { get; set; }
        public string MibFilesPackageId { get; set; }

        public MibUploadPackageProperty MibFilesPackage { get; set; }
        public Vendor Vendor { get; set; }
    }
}
