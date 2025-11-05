using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Servicio;
using COREBAK.Pedido_.Entidad;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio
{
    internal class ServicioDominio 
        : IServicioDominio

    {
        private readonly IDelegado Delegado;
        public ServicioDominio(IDelegado delegado)
        {
            Delegado = delegado;
        }
        public async Task CancelarPedido(CancelarPedidoDto pedido)
        {
            EPedido nuevoPedido = new EPedido
            {
                OrderNumber = pedido.OrderNumber
                ,
                CustomerName = pedido.CustomerName
                ,
                CustomerEmail = pedido.CustomerEmail
                ,
                OrderDate = pedido.OrderDate
                ,
                Status = pedido.Status
                ,
                TotalAmount = pedido.TotalAmount
                ,
                OrderItemsId = pedido.OrderItemsId
            };
            await Delegado.CancelarPedido(nuevoPedido);
        }
    }
}