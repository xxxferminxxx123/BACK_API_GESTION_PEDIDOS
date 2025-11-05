using COREBAK.BDAdapter;
using COREBAK.JsonAdaptor;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Aplicacion;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Aplicacion.Servicio;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Infraestructura.Persistencia;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Infraestructura.Puerto;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Infraestructura.Adaptador
{
    public class CancelarPedidoAdaptador
        : ICancelarPedidoPuerto
    {
        private readonly IDelegado? Repositorio;
        private readonly IServicioAplicacion? Servicio;
        private readonly IJsonAdaptador _jsonAdaptador;

        public CancelarPedidoAdaptador(DBAdaptador _dbAdaptador, IJsonAdaptador jsonAdaptador)
        {
            Repositorio = new BaseDatosSQL(_dbAdaptador);
            Servicio = new ServicioAplicacion(Repositorio);
            _jsonAdaptador = jsonAdaptador;
        }
        public async Task CancelarPedido(string pedidoJson, string jsonLogAplicacion)
        {
            CancelarPedidoDto pedido = _jsonAdaptador.Deserializar<CancelarPedidoDto>(pedidoJson);
            await Servicio!.CancelarPedido(pedido);
        }
    }
}