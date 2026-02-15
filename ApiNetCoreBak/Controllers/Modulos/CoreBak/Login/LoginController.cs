using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Login
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly string _key;
        private string key = "1uCpfKVEM7F7PnMJ1ZQSslduRbf8osyTNQxIkt1T5KI";

        public LoginController(IConfiguration configuration)
        {
            _key = configuration["Jwt:Key"] ?? key;
        }   

        [HttpGet]
        public IActionResult Authenticate([FromQuery]string user, [FromQuery] string pass)
        {
            if (user == "fer" && pass == "fer")
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var byteKey = Encoding.UTF8.GetBytes(_key);

                var tokenDs = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user)
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(byteKey),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDs);
                return Ok(new { token = tokenHandler.WriteToken(token) });
            }

            return Unauthorized(new { message = "Credenciales inválidas" });
        }
    }
}