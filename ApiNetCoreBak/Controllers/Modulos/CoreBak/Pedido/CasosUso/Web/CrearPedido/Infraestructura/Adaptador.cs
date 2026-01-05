using ApiNetCoreBak.Controllers.Modulos.CoreBak.Pedido.CasosUso.Web.CrearPedido.Dto;
using COREBAK.JsonAdaptor;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Puerto;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetCoreBak.Controllers.Modulos.CoreBak.Pedido.CasosUso.Web.CrearPedido.Infraestructura
{
    public class Adaptador(
                ICrearPedidoPuerto servicio
              , IJsonAdaptador jsonAdaptador
        )
    {
        private readonly ICrearPedidoPuerto CrearPedidoAdaptador = servicio;
        private readonly IJsonAdaptador? JsonAdaptador = jsonAdaptador;

        public async Task<IActionResult> CrearPedido(CrearPedidoBodyDto usuario)
        {
            string jsonLog = "";
            try
            {
                string jsonPedido = JsonAdaptador!.Serializar(usuario);
                
                await CrearPedidoAdaptador.CrearPedido(jsonPedido, jsonLog);

                return new ObjectResult(new
                {
                    success = true, 
                    message = "Pedido registrado exitosamente",
                    data = usuario
                })
                {
                    StatusCode = 200
                };

            }
            catch (Exception ex)
            {
                return new ObjectResult(new
                {
                    success = false,
                    message = ex.Message
                })
                {
                    StatusCode = 400
                };
            }
        }
    }

}