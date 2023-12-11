using System.Text.Json.Serialization;

namespace CreditMate.Application.Dtos.CreditoDtos
{
    public class CreditoResponseDto
    {
        public bool Approved { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorJuros { get; set; }

    }
}
