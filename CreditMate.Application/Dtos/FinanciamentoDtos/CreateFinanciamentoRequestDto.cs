using CreditMate.Core.Entities;
using CreditMate.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Application.Dtos.FinanciamentoDtos
{
    public class CreateFinanciamentoRequestDto
    {
        public Guid Id { get; set; }
        public required string Cpf { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime UltimoVencimento { get; set; }
        public TipoFinanciamentoEnum TipoFinanciamento { get; set; }
    }
}
