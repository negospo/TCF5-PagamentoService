namespace Application.Interfaces.RabbitMQ
{
    public interface IPedidoPagamentoStatus
    {
        public bool SendToQueue(Application.DTOs.RabbitMQ.PagamentoStatusRequest pagamentoStatus);
    }
}
