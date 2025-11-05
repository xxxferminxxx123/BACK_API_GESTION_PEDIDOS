using COREBAK.BDAdapter;
using COREBAK.Pedido_.Entidad;
using COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Delegados;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Infraestructura.Persistencia
{
    internal class BaseDatosSQL
        : IDelegado
    {
        public readonly DBAdaptador _dbAdaptador;

        public BaseDatosSQL(DBAdaptador dbAdaptador)
        {
            _dbAdaptador = dbAdaptador;
        }
        public async Task CancelarPedido(EPedido pedido)
        {
            Dictionary<string, dynamic> parametros = new()
            {
              { "@ORDER_NUMBER" ,pedido.OrderNumber }
             ,{ "@CUSTOMER_NAME" ,pedido.CustomerName }
             ,{ "@CUSTOMER_EMAIL" ,pedido.CustomerEmail }
             ,{ "@ORDER_DATE" ,pedido.OrderDate }
             ,{ "@STATUS" ,pedido.Status }
             ,{ "@TOTAL_AMOUNT" ,pedido.TotalAmount }
             ,{ "@ORDER_ITEMS_ID" ,pedido.OrderItemsId }
            };

            await _dbAdaptador!.SpManipulacionDatos("SGP_API_COREBAK_CANCELAR_PEDIDO", parametros);
        }
    }
}