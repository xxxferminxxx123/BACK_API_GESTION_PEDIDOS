using COREBAK.BDAdapter;
using COREBAK.JsonAdaptor;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Aplicacion;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Aplicacion.Servicio;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Persistencia;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Puerto;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Adaptador
{
    public class CrearPedidoAdaptador
        : ICrearPedidoPuerto
    {
        private readonly IDelegado? Repositorio;
        private readonly IServicioAplicacion? Servicio;
        private readonly IJsonAdaptador _jsonAdaptador;

        public CrearPedidoAdaptador(DBAdaptador _dbAdaptador, IJsonAdaptador jsonAdaptador)
        {
            Repositorio = new BaseDatosSQL(_dbAdaptador);
            Servicio = new ServicioAplicacion(Repositorio);
            _jsonAdaptador = jsonAdaptador;
        }
        public async Task CrearPedido(string pedidoJson, string jsonLogAplicacion)
        {
            CrearPedidoDto pedido = _jsonAdaptador.Deserializar<CrearPedidoDto>(pedidoJson);
            await Servicio!.CrearPedido(pedido);
        }
    }
}