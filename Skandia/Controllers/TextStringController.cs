using Logic.TextString;
using Microsoft.AspNetCore.Mvc;

namespace Skandia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextStringController : ControllerBase
    {

        private readonly ITextStringLogic _textStringLogic;
        public TextStringController(ITextStringLogic textStringLogic)
        {
            this._textStringLogic = textStringLogic;
        }


        /// <summary>
        /// Accion que retorna cadena de texto invertida.
        /// </summary>
        /// <returns>Cadena de texto.</returns>
        [HttpGet(("{text}"))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTextString(string text)
        {
            var result = await _textStringLogic.GetTextString(text);
            return Ok(result);
        }
    }
}
