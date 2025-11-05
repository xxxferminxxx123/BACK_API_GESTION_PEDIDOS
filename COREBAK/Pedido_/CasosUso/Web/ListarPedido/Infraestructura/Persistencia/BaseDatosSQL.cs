using COREBAK.BDAdapter;
using COREBAK.Pedido_.Entidad;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio.Delegados;

namespace COREBAK.Pedido_.CasosUso.Web.ListarPedido.Infraestructura.Persistencia
{
    internal class BaseDatosSQL
        : IDelegado
    {
        public readonly DBAdaptador _dbAdaptador;

        public BaseDatosSQL(DBAdaptador dbAdaptador)
        {
            _dbAdaptador = dbAdaptador;
        }
        public async Task<string> ListarPedido()
        {
           return await _dbAdaptador!.SpConsultaJson("SGP_API_COREBAK_LISTAR_PEDIDO");
        }
    }
}