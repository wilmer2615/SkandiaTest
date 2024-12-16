using Logic.CreditCardLogic;
using Microsoft.AspNetCore.Mvc;

namespace Skandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardLogic _creditCardLogic;

        public CreditCardController(ICreditCardLogic _creditCardLogic)
        {
            this._creditCardLogic = _creditCardLogic;
        }


        /// <summary>
        /// Accion que permite listar deuda por franquicia.
        /// </summary>
        /// <returns>Lista de deuda por franquicia.</returns>
        [HttpGet("SP-FranchiseDebt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFranchiseDebt()
        {
            var result = await _creditCardLogic.GetFranchiseDebts();
            return Ok(result);
        }

        /// <summary>
        /// Lista Accionistas que son clientes con su correspondiente Saldo Total de Deuda de todas las tarjetas de crédito
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        [HttpGet("SP-TotalDebtBalanceShareholders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTotalDebtBalanceShareholders()
        {
            var result = await _creditCardLogic.GetTotalDebtBalanceShareholders();
            return Ok(result);
        }
    }
}
