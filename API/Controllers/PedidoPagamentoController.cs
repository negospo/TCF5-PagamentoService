using API.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Pedido")]
    public class PedidoPagamentoController : ControllerBase
    {
        private readonly Application.Interfaces.UseCases.IPedidoPagamentoUseCase _pedidoPagamentoUseCase;

        public PedidoPagamentoController(Application.Interfaces.UseCases.IPedidoPagamentoUseCase pedidoPagamentoUseCase)
        {
            this._pedidoPagamentoUseCase = pedidoPagamentoUseCase;
        }


        /// <summary>
        /// Lista o pedido pagamento passado por parâmetro
        /// </summary>
        [HttpGet]
        [Route("{pedidoId}")]
        [ProducesResponseType(typeof(Application.DTOs.Output.PedidoPagamento), 200)]
        public ActionResult<IEnumerable<Application.DTOs.Output.PedidoPagamento>> Get(int pedidoId)
        {
            try
            {
                return Ok(_pedidoPagamentoUseCase.Get(pedidoId));
            }
            catch (Application.CustomExceptions.NotFoundException ex)
            {
                return NotFound(ex.Message);
            }

            
        }

        /// <summary>
        /// Lista todos os pedidos pagamentos passados por parâmetro..
        /// </summary>
        [HttpPost]
        [Route("list")]
        [ProducesResponseType(typeof(IEnumerable<Application.DTOs.Output.PedidoPagamento>), 200)]
        public ActionResult<IEnumerable<Application.DTOs.Output.PedidoPagamento>> List(List<int> pedidoIds)
        {
            return Ok(_pedidoPagamentoUseCase.List(pedidoIds));
        }
    }
}
