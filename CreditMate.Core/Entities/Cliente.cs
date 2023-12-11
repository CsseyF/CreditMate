namespace CreditMate.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public required string Nome { get; set; }
        public required string Cpf { get; set; }
        public required string Uf { get; set; }
        public required string Celular { get; set; }
        public IEnumerable<Financiamento>? Financiamentos { get; set; }
    }
}
