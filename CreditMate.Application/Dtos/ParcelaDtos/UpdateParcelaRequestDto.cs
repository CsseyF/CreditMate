using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Application.Dtos.ParcelaDtos
{
    public class UpdateParcelaRequestDto
    {
        public Guid Id { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
