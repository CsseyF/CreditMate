namespace CreditMate.Application.Dtos
{
    public class CreditoResponseDto
    {
        public bool Approved { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorJuros { get; set; }

    }
}
