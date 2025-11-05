using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Dto;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Aplicacion.Servicio
{
    internal interface IServicioAplicacion
    {
        Task CancelarPedido(CancelarPedidoDto pedido);
    }
}
