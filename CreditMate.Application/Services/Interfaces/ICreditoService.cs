using CreditMate.Application.Dtos.CreditoDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Application.Services.Interfaces
{
    public interface ICreditoService
    {
        Task<CreditoResponseDto> ProcessamentoCredito(CreditoRequestDto request,
            CancellationToken cancellationToken);
    }
}
