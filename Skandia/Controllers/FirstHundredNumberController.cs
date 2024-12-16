using Logic.FirstHundredNumbers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Skandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstHundredNumberController : ControllerBase
    {
        private readonly IFirstHundredNumbersLogic _firstHundredNumbersLogic;
        public FirstHundredNumberController(IFirstHundredNumbersLogic firstHundredNumbersLogic)
        {
            this._firstHundredNumbersLogic = firstHundredNumbersLogic;
        }


        /// <summary>
        /// Accion que permite listar los numeros del 1-100.
        /// </summary>
        /// <returns>Lista de numeros.</returns>
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFirtsHundredNumbers()
        {
            var result = await _firstHundredNumbersLogic.GetFirtsHundredNumbers();
            return Ok(result);
        }

    }
}
