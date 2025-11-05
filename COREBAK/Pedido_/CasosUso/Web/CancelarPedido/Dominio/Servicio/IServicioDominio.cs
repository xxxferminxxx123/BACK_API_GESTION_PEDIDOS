using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Servicio
{
    internal interface IServicioDominio
    {
        Task CancelarPedido(CancelarPedidoDto pedido);
    }
}
