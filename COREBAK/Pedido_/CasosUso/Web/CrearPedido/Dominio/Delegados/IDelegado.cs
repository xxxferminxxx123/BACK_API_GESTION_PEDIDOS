using COREBAK.Pedido_.Entidad;

namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Delegados
{
    internal interface IDelegado
    {
        Task CrearPedido(EPedido pedido);
    }
}