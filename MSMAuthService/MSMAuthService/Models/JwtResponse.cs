using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMAuthService.Models
{
    public class JwtResponse
    {
        public string auth_token { get; set; }

        public long expires_in { get; set; }

        public string Jti { get; set; }
    }

    public class RefreshToken
    {
        public string Username { get; set; }
        public string Jti { get; set; }
        public bool Revoked { get; set; }
    }
}
