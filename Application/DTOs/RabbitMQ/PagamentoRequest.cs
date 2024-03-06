namespace Application.DTOs.RabbitMQ
{
    public class PagamentoStatusRequest
    {
        public int PedidoId { get; set; }
        public Enums.PagamentoStatus PagamentoStatus { get; set; }
    }
}
