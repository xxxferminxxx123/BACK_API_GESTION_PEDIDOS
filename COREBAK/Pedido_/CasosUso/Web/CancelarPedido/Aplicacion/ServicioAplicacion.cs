using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Aplicacion.Servicio;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Servicio;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Aplicacion
{
    internal class ServicioAplicacion
            : IServicioAplicacion
    {
        private readonly IServicioDominio ServicioDominio;

        public ServicioAplicacion(IDelegado delegado)
        {
            ServicioDominio = new ServicioDominio(delegado);
        }

        public async Task CancelarPedido(CancelarPedidoDto pedido)
        {
            await ServicioDominio.CancelarPedido(pedido);
        }
    }
}