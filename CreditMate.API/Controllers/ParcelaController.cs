using CreditMate.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CreditMate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParcelaController : Controller
    {
        private readonly IParcelaService _parcelaService;

        public ParcelaController(IParcelaService parcelaService)
        {
            _parcelaService = parcelaService;
        }

        [HttpGet]
        public async Task<IActionResult> FindAllAsync(CancellationToken cancellationToken)
        {
            var result = await _parcelaService.FindAllAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> FindOneAsync([FromRoute] Guid id,
            CancellationToken cancellationToken)
        {
            var result = await _parcelaService.FindOneAsync(id, cancellationToken);
            return Ok(result);
        }

        [HttpGet, Route("financiamento/{financiamentoId}")]
        public async Task<IActionResult> FindByFinanciamentoAsync([FromRoute] Guid financiamentoId,
            CancellationToken cancellationToken)
        {
            var result = await _parcelaService.FindAllByFinanciamentoAsync(financiamentoId, cancellationToken);
            return Ok(result);
        }
    }
}
