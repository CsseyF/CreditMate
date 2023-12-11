using CreditMate.Core.Enums;

namespace CreditMate.Application.Dtos.CreditoDtos
{
    public class CreditoRequestDto
    {
        public Guid ClienteId { get; set; }
        public decimal ValorSolicitado { get; set; }
        public TipoFinanciamentoEnum TipoFinanciamento { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime PrimeiroVencimento { get; set; }

    }
}
