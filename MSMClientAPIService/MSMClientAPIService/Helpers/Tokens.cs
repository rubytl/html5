using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MSMClientAPIService.Helpers
{
    public class Tokens
    {
        public static async Task<string> GenerateJwt(IJwtFactory jwtFactory, string userName, JwtIssuerOptions jwtOptions)
        {
            var response = new
            {
                auth_token = await jwtFactory.GenerateJwtToken(userName),
                expires_in = (int)jwtOptions.ValidFor.TotalMinutes
            };

            return JsonConvert.SerializeObject(response);
        }
    }
}
