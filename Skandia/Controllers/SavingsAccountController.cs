using Logic.SavingsAccountLogic;
using Microsoft.AspNetCore.Mvc;

namespace Skandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsAccountController : ControllerBase
    {
        private readonly ISavingAccountLogic _savingAccountLogic;

        public SavingsAccountController(ISavingAccountLogic savingAccountLogic)
        {
            this._savingAccountLogic = savingAccountLogic;
        }

        /// <summary>
        /// Accion que permite listar cliente con mayor saldo en canje.
        /// </summary>
        /// <returns>Obtiene cliente con mayor saldo en canje.</returns>
        [HttpGet("SP-HighestBalanceExchange")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetHighestBalanceExchange()
        {
            var result = await _savingAccountLogic.GetHighestBalanceExchange();
            return Ok(result);
        }

        /// <summary>
        /// Accion que Obtiene Cliente con mayor saldo retirado de una Cuenta de Ahorros.
        /// </summary>
        /// <returns>Obtiene Cliente con mayor saldo retirado de una Cuenta de Ahorros.</returns>
        [HttpGet("SP-HighestWithdrawnBalance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetHighestWithdrawnBalance()
        {
            var result = await _savingAccountLogic.GetHighestWithdrawnBalance();
            return Ok(result);
        }

        /// <summary>
        /// Accion que Obtiene Cuenta de Ahorro con mayor número de titulares. 
        /// </summary>
        /// <returns>Obtiene Cuenta de Ahorro con mayor número de titulares.</returns>
        [HttpGet("SP-AccountMoreHeadlines")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAccountMoreHeadlines()
        {
            var result = await _savingAccountLogic.GetAccountMoreHeadlines();
            return Ok(result);
        }

        /// <summary>
        /// Accion que Obtiene Saldo Total de todas las cuentas de ahorro de un cliente. 
        /// </summary>
        /// <returns>Obtiene Saldo Total de todas las cuentas de ahorro de un cliente.</returns>
        [HttpGet("SP-CustomerAccountBalance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerAccountBalance()
        {
            var result = await _savingAccountLogic.GetCustomerAccountBalance();
            return Ok(result);
        }

        /// <summary>
        /// Accion que Obtiene Numero de Cuentas de Ahorro activas de clientes extranjeros. 
        /// </summary>
        /// <returns>Obtiene Numero de Cuentas de Ahorro activas de clientes extranjeros.</returns>
        [HttpGet("SP-ActiveForeignAccounts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetActiveForeignAccounts()
        {
            var result = await _savingAccountLogic.GetActiveForeignAccounts();
            return Ok(result);
        }
    }
}
