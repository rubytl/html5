using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMAuthService.Models
{
    public class RefreshTokenModel
    {
        public string Token { get; set; }
    }

    public class LoginModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
