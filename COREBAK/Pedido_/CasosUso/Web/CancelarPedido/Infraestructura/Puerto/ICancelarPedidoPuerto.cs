namespace COREBAK.Pedido_.CasosUso.Web.CancelarPedido.Infraestructura.Puerto
{
    public interface ICancelarPedidoPuerto
    {
        Task CancelarPedido(string pedido, string jsonLogAplicacion);
    }
}
