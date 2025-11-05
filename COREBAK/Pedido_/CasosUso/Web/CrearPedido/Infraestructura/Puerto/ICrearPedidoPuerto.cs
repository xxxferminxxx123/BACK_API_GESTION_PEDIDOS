namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Puerto
{
    public interface ICrearPedidoPuerto
    {
        Task CrearPedido(string pedido, string jsonLogAplicacion);
    }
}