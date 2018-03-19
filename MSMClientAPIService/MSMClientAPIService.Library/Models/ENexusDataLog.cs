using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class ENexusDataLog
    {
        public long Id { get; set; }
        public int SiteId { get; set; }
        public Guid? SessionId { get; set; }
        public short Function { get; set; }
        public short SystemType { get; set; }
        public short SystemIndex { get; set; }
        public short SubSystem { get; set; }
        public short SubSystemIndex { get; set; }
        public short DataObject { get; set; }
        public short ElementId { get; set; }
        public string Description { get; set; }
        public short DataType { get; set; }
        public short DataSize { get; set; }
        public string InitialValue { get; set; }
        public string WriteValue { get; set; }
        public string ResultValue { get; set; }
        public string Response { get; set; }

        public Site Site { get; set; }
    }
}
