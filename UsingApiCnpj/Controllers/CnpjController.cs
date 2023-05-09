using Microsoft.AspNetCore.Mvc;
using System.Net;
using UsingApiCnpj.Interfaces;

namespace UsingApiCnpj.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CnpjController : ControllerBase
    {
        public readonly ICnpjService _cnpjService;

        //injetando
        public CnpjController(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        //criando rota
        [HttpGet("cnpj/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscarCnpj([FromRoute] string cnpj)
        {
            var response = await _cnpjService.BuscarEmpresaPorCnpj(cnpj);

            if (response.HttpStatusCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.HttpStatusCode, response.ReturnError);
            }
        }
    }
}
