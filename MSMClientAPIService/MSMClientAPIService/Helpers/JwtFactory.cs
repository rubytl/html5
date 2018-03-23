using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MSMClientAPIService.Models;
using System.Linq;

namespace MSMClientAPIService.Helpers
{
    public class JwtFactory : IJwtFactory
    {
        private readonly JwtIssuerOptions jwtOptions;
        private readonly ISet<RefreshToken> refreshTokens = new HashSet<RefreshToken>();

        public JwtFactory(IOptions<JwtIssuerOptions> jwtOptions)
        {
            this.jwtOptions = jwtOptions.Value;
            this.ThrowIfInvalidOptions(this.jwtOptions);
        }

        private void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.ValidFor <= TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(JwtIssuerOptions.ValidFor));
            }

            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));
            }

            if (options.JtiGenerator == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
            }
        }

        public async Task<JwtResponse> GenerateJwtToken(string username)
        {
            string jti = await this.jwtOptions.JtiGenerator();
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.GivenName, username),
                new Claim(JwtRegisteredClaimNames.Jti, jti),
                new Claim("role","Admin")
            };

            var jwt = new JwtSecurityToken(
                issuer: this.jwtOptions.Issuer,
                audience: this.jwtOptions.Audience,
                claims: claims,
                notBefore: this.jwtOptions.NotBefore,
                expires: this.jwtOptions.Expiration,
                signingCredentials: this.jwtOptions.SigningCredentials
            );

            string token = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new JwtResponse()
            {
                auth_token = token,
                expires_in = (int)jwtOptions.ValidFor.TotalMinutes,
                Jti = jti
            };

            this.refreshTokens.Add(new RefreshToken() { Username = username, Jti = jti });
            return await Task.FromResult(response);
        }

        public async Task<ClaimsPrincipal> GetPrincipal(string token)
        {
            try
            {
                token = Tokens.RefreshToken(token);
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null)
                    return null;
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    RequireExpirationTime = true,
                    ValidateLifetime = false,
                    IssuerSigningKey = this.jwtOptions.SecurityKey
                };
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token,
                      parameters, out securityToken);
                return await Task.FromResult(principal);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<bool> RemoveRefreshToken(string token)
           => Task.FromResult(this.refreshTokens.Remove(this.GetRefreshToken(token).Result));

        public Task<RefreshToken> GetRefreshToken(string token)
        {
            token = Tokens.RefreshToken(token);
            return Task.FromResult(this.refreshTokens.SingleOrDefault(x => x.Jti == token));
        }
    }
}
