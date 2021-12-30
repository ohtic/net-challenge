using Microsoft.IdentityModel.Tokens;
using Ohtic.Challenge.Web.Data;
using Ohtic.Challenge.Web.Data.Entities;
using Ohtic.Challenge.Web.Services.Auth.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ohtic.Challenge.Web.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ChallengeContext _challenge;

        public AuthService(ChallengeContext challenge)
        {
            _challenge = challenge;
        }

        public async Task<LoginResponse> Login(string username, string password)
        {
            UserEntity user = _challenge.Property1.FirstOrDefault(user => user.Email == username);

            //TODO: Validate correct Password using Bcrypt (already installed as nuget)
            // More info at: https://jasonwatmore.com/post/2020/07/16/aspnet-core-3-hash-and-verify-passwords-with-bcrypt

            return new LoginResponse();
        }

        private string GenerateAccessToken(string customerEmail)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = new byte[0]; //Get the key from Configuration
            DateTime expiration = DateTime.UtcNow.AddMinutes(25); //Get the key expiration from Configuration
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, customerEmail),
                }),
                Expires = expiration,
                Audience = "", //Get from config
                Issuer = "", //Get from config
                IssuedAt = DateTime.UtcNow,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
