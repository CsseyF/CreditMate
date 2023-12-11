using CreditMate.Application.Dtos.CreditoDtos;
using CreditMate.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CreditMate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditoController : ControllerBase
    {
        private readonly ICreditoService _creditoService;
        public CreditoController(ICreditoService creditoService)
        {
            _creditoService = creditoService;
        }

        [HttpPost]
        public async Task<CreditoResponseDto> SolicitarCredito([FromBody]CreditoRequestDto request,
            CancellationToken cancellationToken)
        {
            var result = await _creditoService
                .ProcessamentoCredito(request, cancellationToken);
            return result;
        }
    }
}
