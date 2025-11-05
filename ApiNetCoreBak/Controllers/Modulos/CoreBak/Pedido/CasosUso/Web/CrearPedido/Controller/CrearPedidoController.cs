using ApiNetCoreBak.Controllers.Modulos.CoreBak.Pedido.CasosUso.Web.CrearPedido.Dto;
using ApiNetCoreBak.Controllers.Modulos.CoreBak.Pedido.CasosUso.Web.CrearPedido.Infraestructura;
using COREBAK.JsonAdaptor;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Puerto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Pedido.CasosUso.Web.CrearPedido.Controller
{
    [Route(RutaPrincipal.API_PEDIDO)]
    [ApiController]
    public class CrearPedidoController(
            ICrearPedidoPuerto crearPedidoAdaptador,
            IJsonAdaptador jsonAdaptador) : ControllerBase
    {
        private readonly Adaptador Adaptador = new(crearPedidoAdaptador, jsonAdaptador);


        [HttpPost(Ruta.CREAR_PEDIDO)]
        public async Task<IActionResult> CrearPedido([FromBody] CrearPedidoBodyDto pedido)
        {
            try
            {
                return await Adaptador.CrearPedido(pedido);

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