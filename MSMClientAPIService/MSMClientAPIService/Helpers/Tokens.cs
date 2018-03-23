using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSMClientAPIService.Models;
using Newtonsoft.Json;

namespace MSMClientAPIService.Helpers
{
    public class Tokens
    {
        public static string RefreshToken(string token)
        {
            return token.Replace("{", string.Empty)
                .Replace("}", string.Empty);
        }
    }
}
