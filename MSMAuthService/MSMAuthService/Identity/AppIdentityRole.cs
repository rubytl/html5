using Microsoft.AspNetCore.Identity;

namespace MSMAuthService.Identity
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
