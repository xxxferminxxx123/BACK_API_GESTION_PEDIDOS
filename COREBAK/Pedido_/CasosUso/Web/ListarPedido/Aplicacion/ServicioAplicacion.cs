using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Aplicacion.Servicio;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio.Servicio;

namespace COREBAK.Pedido_.CasosUso.Web.ListarPedido.Aplicacion
{
    internal class ServicioAplicacion
        : IServicioAplicacion
    {
        private readonly IServicioDominio ServicioDominio;

        public ServicioAplicacion(IDelegado delegado)
        {
            ServicioDominio = new ServicioDominio(delegado);
        }

        public async Task<string> ListarPedido( )
        {
            return await ServicioDominio.ListarPedido();
        }
    }
}