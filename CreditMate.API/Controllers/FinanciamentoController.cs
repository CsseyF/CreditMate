using CreditMate.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CreditMate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinanciamentoController : Controller
    {
        private readonly IFinanciamentoService _financiamentoService;

        public FinanciamentoController(IFinanciamentoService financiamentoService)
        {
            _financiamentoService = financiamentoService;
        }

        [HttpGet]
        public async Task<IActionResult> FindAllAsync(CancellationToken cancellationToken)
        {
            var result = await _financiamentoService.FindAllAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> FindOneAsync([FromRoute] Guid id,
            CancellationToken cancellationToken)
        {
            var result = await _financiamentoService.FindOneAsync(id, cancellationToken);
            return Ok(result);
        }
    }
}
