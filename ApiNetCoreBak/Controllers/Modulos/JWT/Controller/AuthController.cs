using ApiNetCoreBak.Controllers.Modulos.JWT.IJwtTokenService_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.JWT.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IJwtTokenService _jwtTokenService;
        // Inyecta tus servicios de usuario aquí

        public AuthController(IJwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Aquí validas las credenciales del usuario
            // Este es un ejemplo simplificado

            // TODO: Validar credenciales contra la base de datos

            // Si las credenciales son válidas:
            var token = _jwtTokenService.GenerateToken(
                userId: "123",
                email: request.Email,
                roles: new List<string> { "User" }
            );

            return Ok(new { token });
        }
    }
}
    public record LoginRequest(string Email, string Password);