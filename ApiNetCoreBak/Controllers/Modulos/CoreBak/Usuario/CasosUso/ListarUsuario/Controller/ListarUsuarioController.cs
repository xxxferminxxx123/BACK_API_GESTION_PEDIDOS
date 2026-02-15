using COREBAK.Usuario_.CasosUso.ListarUsuario.Aplicacion;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.CasosUso.ListarUsuario.Controller
{
    [ApiController]
    [Route("api/Usuario")]
    public class UsuarioController(
            ServicioAplicacion _listarUsuario
            ) : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult> Listar()
        {
            var datos = await _listarUsuario.ListarUsuario();
            return Ok(datos);
        }
    }
}