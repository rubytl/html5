using System;
using Microsoft.AspNetCore.Identity;

namespace MSMAuthService.Identity
{
    public class AppIdentityUser : IdentityUser
    {
        public string Comment { get; set; }

        public bool Locked { get; set; }

        public string FriendlyName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastLogin { get; set; }
    }
}
