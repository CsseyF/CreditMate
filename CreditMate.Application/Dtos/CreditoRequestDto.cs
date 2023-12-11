using CreditMate.Core.Enums;

namespace CreditMate.Application.Dtos
{
    public class CreditoRequestDto
    {
        public decimal ValorSolicitado { get; set; }
        public TipoFinanciamentoEnum TipoFinanciamento { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime PrimeiroVencimento { get; set; }

    }
}
