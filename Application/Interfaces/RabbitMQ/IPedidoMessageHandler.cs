namespace Application.Interfaces.RabbitMQ
{
    public interface IPedidoPagamentoMessageHandler
    {
        void HandleMessage(string message);
    }
}
