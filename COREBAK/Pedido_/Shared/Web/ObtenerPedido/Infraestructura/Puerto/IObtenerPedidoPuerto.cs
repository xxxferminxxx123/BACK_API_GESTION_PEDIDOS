namespace COREBAK.Pedido.Shared.Web.ObtenerPedido.Infraestructura.Puerto
{
    public interface IObtenerPedidoPuerto
    {
        Task<string> ObtenerPedidoPorId(Guid Id);
    }
}
