using Projekt_10.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace Projekt_10.Services
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(DTOModel model)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creditals = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddHours(1);

            var claims = new[]
            {
                new System.Security.Claims.Claim("Id", model.Id.ToString()),
                new System.Security.Claims.Claim("CustomerName", model.CustomerName ?? ""),
                new System.Security.Claims.Claim("Product", model.Product ?? ""),
                new System.Security.Claims.Claim("Quantity", model.Quantity.ToString())
            };
            
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: creditals
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
