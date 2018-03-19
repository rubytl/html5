using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class EmailAddressBook
    {
        public int DuserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
