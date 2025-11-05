

using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Aplicacion.Servicio;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Servicio;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Aplicacion
{
    internal class ServicioAplicacion
            : IServicioAplicacion
    {
        private readonly IServicioDominio ServicioDominio;

        public ServicioAplicacion(IDelegado delegado)
        {
            ServicioDominio = new ServicioDominio(delegado);
        }

        public async Task CrearPedido(CrearPedidoDto pedido)
        {
            await ServicioDominio.CrearPedido(pedido);
        }
    }
}