using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Application.Dtos.ClienteDtos
{
    public class CreateClienteRequestDto
    {
        public required string Nome { get; set; }
        public required string Cpf { get; set; }
        public required string Uf { get; set; }
        public required string Celular { get; set; }
    }
}
