using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Aplicacion.Servicio
{
    internal interface IServicioAplicacion
    {
        Task CrearPedido(CrearPedidoDto pedido);
    }
}
