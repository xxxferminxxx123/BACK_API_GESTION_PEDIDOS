using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Servicio
{
    internal interface IServicioDominio
    {
        Task CrearPedido(CrearPedidoDto pedido);
    }
}
