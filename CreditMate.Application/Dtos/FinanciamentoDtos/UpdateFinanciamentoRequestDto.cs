using CreditMate.Core.Entities;
using CreditMate.Core.Enums;

namespace CreditMate.Application.Dtos.FinanciamentoDtos
{
    public class UpdateFinanciamentoRequestDto
    {
        public required Guid Id { get; set; }
        public required string Cpf { get; set; }
    }
}
