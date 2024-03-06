using Application.DTOs.RabbitMQ;

namespace Infrastructure.RabbitMQ
{
    public class PedidoPagamentoStatus : Application.Interfaces.RabbitMQ.IPedidoPagamentoStatus
    {
        public bool SendToQueue(PagamentoStatusRequest pagamentoStatus)
        {
            RabbitMQ.Connection.SendMessage("order-payment-status", System.Text.Json.JsonSerializer.Serialize(pagamentoStatus));
            return true;
        }
    }
}
