using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class MibUploadPackageProperty
    {
        public MibUploadPackageProperty()
        {
            ControllerType = new HashSet<ControllerType>();
        }

        public string MibFilesPackageId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public bool IsPredefined { get; set; }

        public ICollection<ControllerType> ControllerType { get; set; }
    }
}
