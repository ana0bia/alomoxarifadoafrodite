using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AlmoxarifadoBackAPI.Services
{
    public class TokenService
    {
        public string GerarToken(string username)
        {
            var chave =Encoding.UTF8.GetBytes("senai2025senai2025senai2025senai2025");
            var credenciais = new SigningCredentials(new SymmetricSecurityKey(chave),
               SecurityAlgorithms.HmacSha256);

            var dados = new[]
            {
                new Claim(ClaimTypes.Name, username)
            };

            var token = new JwtSecurityToken(
                claims: dados,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credenciais);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
