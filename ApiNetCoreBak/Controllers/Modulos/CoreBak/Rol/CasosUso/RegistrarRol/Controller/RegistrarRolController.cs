using COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Aplicacion.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Rol.CasosUso.RegistrarRol.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrarRolController : ControllerBase
    {
        private readonly ServicioAplicacion _registrarRol;

        public RegistrarRolController(
            ServicioAplicacion registrarRol
            )
        {
            _registrarRol = registrarRol;
        }


        [HttpPost]
        [Route("crear")]
        public async Task<ActionResult> Registrar([FromBody] RegistrarRolDTO dto)
        {
            await _registrarRol.RegistrarRol(dto);
            await Task.Delay(3000);
            return Ok();
        }
    }
}