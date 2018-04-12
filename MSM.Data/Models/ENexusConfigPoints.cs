using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class ENexusConfigPoints
    {
        public int Id { get; set; }
        public short ENexusConfigId { get; set; }
        public short? SeqIndex { get; set; }
        public short SystemType { get; set; }
        public short SystemIndex { get; set; }
        public short SubSystem { get; set; }
        public short SubSystemIndex { get; set; }
        public short DataObject { get; set; }
        public short ElementId { get; set; }
        public string Descrition { get; set; }
        public short DataType { get; set; }
        public short DataSize { get; set; }
        public string Data { get; set; }

        public ENexusConfiguration ENexusConfig { get; set; }
    }
}
