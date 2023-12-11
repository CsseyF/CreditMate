using CreditMate.Core.Enums;

namespace CreditMate.Core.Entities
{
    public class Financiamento : BaseEntity
    {
        public required string Cpf { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime UltimoVencimento { get; set; }
        public TipoFinanciamentoEnum TipoFinanciamento { get; set; }
        public IEnumerable<Parcela>? Parcelas { get; set; }
    }
}
