using Microsoft.IdentityModel.Tokens;
using MovieService.Domain.Entities;
using MovieService.Domain.Services;
using MovieService.Domain.Shared;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieService.Infra.Services
{
    public class TokenService : ITokenService
    {
        public string GenerateToken(Account account)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
               {
               new Claim(ClaimTypes.Name, account.Id.ToString()),
               new Claim(ClaimTypes.Role, account.Role)
               }),
                Expires = DateTime.UtcNow.AddDays(365),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
