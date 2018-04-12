using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            ControllerType = new HashSet<ControllerType>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }

        public ICollection<ControllerType> ControllerType { get; set; }
    }
}
