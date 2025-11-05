using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Servicio;
using COREBAK.Pedido_.Entidad;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio
{
    internal class ServicioDominio
        : IServicioDominio

    {
        private readonly IDelegado Delegado;
        public ServicioDominio(IDelegado delegado)
        {
            Delegado = delegado;
        }
        public async Task CrearPedido(CrearPedidoDto pedido)
        {
            EPedido nuevoPedido = new EPedido
            {
                 OrderNumber     = pedido.OrderNumber
                ,CustomerName    = pedido.CustomerName
                ,CustomerEmail   = pedido.CustomerEmail
                ,OrderDate       = pedido.OrderDate
                ,Status          = pedido.Status
                ,TotalAmount     = pedido.TotalAmount
                ,OrderItemsId     = pedido.OrderItemsId
            };
            await Delegado.CrearPedido(nuevoPedido);
        }
    }
}