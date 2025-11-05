
namespace COREBAK.Pedido_.CasosUso.Web.CrearPedido.Dominio.Dto
{
    internal class CrearPedidoDto
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid OrderItemsId { get; set; }
    }
}
