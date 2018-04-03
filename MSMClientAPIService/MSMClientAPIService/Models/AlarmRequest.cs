using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMClientAPIService.Models
{
    public class AlarmRequest
    {
        public string Filter { get; set; }
        public string SiteName { get; set; }

        public string Priority { get; set; }

        public string StatusCode { get; set; }
        public string Trap { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string SortField { get; set; }

        public string SortDirection { get; set; }

        public long MaxAlarmID { get; set; }
    }
}
