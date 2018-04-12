using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class ReportServer
    {
        public int Id { get; set; }
        public string SmtpserverIp { get; set; }
        public string UserName { get; set; }
        public string Psw { get; set; }
        public int Smtpport { get; set; }
        public string EmailServiceAccount { get; set; }
        public int EmailServiceInterval { get; set; }
        public string Status { get; set; }
        public DateTime? StatusTimeStamp { get; set; }
    }
}
