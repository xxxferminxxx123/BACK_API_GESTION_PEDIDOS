using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.CasosUso.RegistrarUsuario.Controller
{
    [ApiController]
    [Route("api/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly ServicioAplicacion _registrarUsuario;

        public UsuarioController(
            ServicioAplicacion registrarUsuario
            )
        {
            _registrarUsuario = registrarUsuario;
        }


        [HttpPost]
        [Route("crear")]
        public async Task<ActionResult> Crear([FromBody] RegistrarUsuarioDTO dto)
        {
                await _registrarUsuario.RegistrarUsuario(dto);
                return Ok(); 
        }
    }
}