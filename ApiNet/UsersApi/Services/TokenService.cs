using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using UsersApi.Domain.interfaces;
using UsersApi.Domain.Models;

namespace UsersApi.Services
{
    public class TokenService(IConfiguration configuration) : ITokenService
    {
    private readonly IConfiguration _configuration = configuration;

        public string GenerateToken(User user)
        {
            Claim[] clams = new Claim[]
            {
            new Claim("usename", user.UserName),
            new Claim("id", user.Id),
            new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth.ToString("yyyy-MM-dd")),
            };
            var sKey = _configuration["SymmetricSecurityKey"] ?? string.Empty;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(sKey));

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                expires: DateTime.UtcNow.AddHours(10),
                claims: clams,
                signingCredentials: signingCredentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}