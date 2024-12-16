using Logic.FirstHundredNumbers;
using Logic.PrimeNumbers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Skandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeNumbersController : ControllerBase
    {
        private readonly IPrimeNumbersLogic _primeNumbersLogic;
        public PrimeNumbersController(IPrimeNumbersLogic primeNumbersLogic)
        {
            this._primeNumbersLogic = primeNumbersLogic;
        }


        /// <summary>
        /// Accion que permite listar los numeros primos.
        /// </summary>
        /// <returns>Lista de numeros primos.</returns>
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPrimeNumbers()
        {
            var result = await _primeNumbersLogic.GetPrimeNumbers();
            return Ok(result);
        }
    }
}
