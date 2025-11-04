using COREBAK.JsonAdaptor;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Puerto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.Infraestructura;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.Controller
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController(
            IRegistrarUsuarioPuerto registrarUsuarioAdaptador,
            IJsonAdaptador jsonAdaptador) : ControllerBase  
    {


        private readonly Adaptador Adaptador = new(registrarUsuarioAdaptador, jsonAdaptador );


        [HttpPost("registrar")]
        public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioDto usuario)
        {
            string jsonLog = "";
            try
            {
                return await Adaptador.RegistarUsuario(usuario);

            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }
    }
}