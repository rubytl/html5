using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class GlobalKpi
    {
        public short Id { get; set; }
        public string Catalog { get; set; }
        public byte IndexInCatalog { get; set; }
        public string Description { get; set; }
        public int? NumUpsite { get; set; }
        public int? TotValSite { get; set; }
        public short? Kpivalue { get; set; }
        public short? GlobalTarget { get; set; }
        public byte? KpivalStatus { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
