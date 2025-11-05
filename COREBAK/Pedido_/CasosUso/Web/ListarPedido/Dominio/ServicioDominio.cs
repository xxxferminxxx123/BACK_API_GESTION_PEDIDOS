using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio.Delegados;
using COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio.Servicio;

namespace COREBAK.Pedido_.CasosUso.Web.ListarPedido.Dominio
{
    internal class ServicioDominio
        : IServicioDominio

    {
        private readonly IDelegado Delegado;
        public ServicioDominio(IDelegado delegado)
        {
            Delegado = delegado;
        }
        public async Task<string> ListarPedido()
        {
            return await Delegado.ListarPedido();
        }
    }
}