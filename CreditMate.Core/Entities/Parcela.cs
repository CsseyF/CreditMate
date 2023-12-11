namespace CreditMate.Core.Entities
{
    public class Parcela : BaseEntity
    {
        public Guid FinanciamentoId { get; set; }
        public int NumeroParcela { get; set; }
        public decimal Valor { get; set; }
        public DateTime ValorVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
