using CreditMate.Application.Dtos.ClienteDtos;
using CreditMate.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CreditMate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> FindAllAsync(CancellationToken cancellationToken)
        {
            var result = await _clienteService.FindAllAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> FindOneAsync([FromRoute]Guid clienteId,
            CancellationToken cancellationToken)
        {
            var result = await _clienteService.FindOneAsync(clienteId, cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] CreateClienteRequestDto request,
            CancellationToken cancellationToken)
        {
            var result = await _clienteService.InsertAsync(request, cancellationToken);
            return Ok(result);
        }
    }
}
