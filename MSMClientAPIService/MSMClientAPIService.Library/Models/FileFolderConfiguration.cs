using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class FileFolderConfiguration
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public byte FileType { get; set; }
    }
}
