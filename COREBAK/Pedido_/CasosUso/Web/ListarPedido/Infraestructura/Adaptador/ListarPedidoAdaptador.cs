using COREBAK.BDAdapter;
using COREBAK.JsonAdaptor;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Aplicacion;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Aplicacion.Servicio;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Infraestructura.Persistencia;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Infraestructura.Puerto;

namespace COREBAK.Pedido_.CasosUso.Web.ListarPedido.Infraestructura.Adaptador
{
    public class ListarPedidoAdaptador
        : IListarPedidoPuerto
    {
        private readonly IDelegado? Repositorio;
        private readonly IServicioAplicacion? Servicio;
        private readonly IJsonAdaptador _jsonAdaptador;

        public ListarPedidoAdaptador(DBAdaptador _dbAdaptador, IJsonAdaptador jsonAdaptador)
        {
            Repositorio = new BaseDatosSQL(_dbAdaptador);
            Servicio = new ServicioAplicacion(Repositorio);
            _jsonAdaptador = jsonAdaptador;
        }
        public async Task<string> ListarPedido()
        {
            return await Servicio!.ListarPedido();
        }
    }
}