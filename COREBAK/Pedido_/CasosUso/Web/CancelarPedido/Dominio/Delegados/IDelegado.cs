using COREBAK.Pedido_.Entidad;

namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Dominio.Delegados
{
    internal interface IDelegado
    {
        Task CancelarPedido(EPedido pedido);
    }
}
