using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProS.GestaoServico.Entidades.Model;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Text;

namespace api__ProS.GestaoServico.Services
{
    public static class TokenService
    {
        private static readonly IConfiguration configuration;
        private static readonly ConfigurationBuilder ConfigurationBuilder;

        static TokenService()
        {
            if (ConfigurationBuilder == null)
            {
                ConfigurationBuilder = new ConfigurationBuilder();
                ConfigurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
                ConfigurationBuilder.AddJsonFile("appsettings.json", optional: true);

                if (configuration == null)
                    configuration = ConfigurationBuilder.Build();
            }
        }

        public static object GenerateToken(UsuarioModel usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(configuration["Token:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                  {
                  new Claim(ClaimTypes.Sid , usuario.IdUsuario.ToString()),
                  new Claim(ClaimTypes.Name , usuario.Login.ToString()),
                  new Claim(ClaimTypes.Role , usuario.NomePerfil.ToString())
                  }),
                Expires = DateTime.UtcNow.AddHours(Convert.ToDouble(configuration["Token:Duracao"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            return new
            {
                authenticated = true,
                accessToken = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor)),
                type = "bearer",
            };
        }
    }
}