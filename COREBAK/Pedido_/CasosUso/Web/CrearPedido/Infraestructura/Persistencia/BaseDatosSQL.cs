using COREBAK.Middleware.BDAdapter;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Delegados;
using COREBAK.Pedido_.Entidad;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Persistencia
{
    public class BaseDatosSQL
        : IDelegado
    {
        private readonly IDBAdaptador _dbAdaptador;
        public BaseDatosSQL(IDBAdaptador dbAdaptador)
        {
            _dbAdaptador = dbAdaptador;
        }
        public async Task CrearPedido(EPedido pedido)
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

            await _dbAdaptador!.SpManipulacionDatos("SGP_API_COREBAK_CREAR_PEDIDO", parametros);
        }
    }
}