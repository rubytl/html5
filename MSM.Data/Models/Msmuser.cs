using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class Msmuser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastActivityDate { get; set; }
    }
}
