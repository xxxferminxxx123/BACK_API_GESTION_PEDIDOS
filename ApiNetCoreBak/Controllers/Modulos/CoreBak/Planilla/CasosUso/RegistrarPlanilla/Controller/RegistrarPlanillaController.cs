using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion;
using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Planilla.CasosUso.RegistrarPlanilla.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegistrarPlanillaController : ControllerBase
    {
        private readonly ServicioAplicacion registrarPlanilla;

        public RegistrarPlanillaController(
            ServicioAplicacion registrarRol
            )
        {
            registrarPlanilla = registrarRol;
        }


        [HttpPost]
        [Route("crear")]
        public async Task<ActionResult> Registrar([FromBody] RegistrarPlanillaDTO dto)
        {
            await registrarPlanilla.RegistrarPlanilla(dto);
            //await Task.Delay(3000);
            return Ok();
        }
    }
}