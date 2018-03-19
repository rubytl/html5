using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class FileStreamProperty
    {
        public Guid RefId { get; set; }
        public byte FileType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public bool IsPredefined { get; set; }
        public string LastWriteBy { get; set; }
        public DateTime? LastWriteDate { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
    }
}
