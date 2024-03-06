using Application.Interfaces.UseCases;

namespace Application.Implementations
{
    public class PedidoPagamentoMessageHandler : Interfaces.RabbitMQ.IPedidoPagamentoMessageHandler
    {
        IPedidoPagamentoUseCase _pedidoPagamentoUseCase;

        public PedidoPagamentoMessageHandler(IPedidoPagamentoUseCase pedidoPagamentoUseCase)
        {
            this._pedidoPagamentoUseCase = pedidoPagamentoUseCase;
        }

        public void HandleMessage(string message)
        {
            var newOrder = System.Text.Json.JsonSerializer.Deserialize<DTOs.Imput.Pedido>(message);
            this._pedidoPagamentoUseCase.Save(newOrder);
        }
    }
}
