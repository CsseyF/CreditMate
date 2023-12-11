using CreditMate.Application.Dtos.FinanciamentoDtos;
using CreditMate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Application.Services.Interfaces
{
    public interface IFinanciamentoService
    {
        Task<Financiamento>? FindOneAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Financiamento>> FindAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<Financiamento>> FindAllByCpfAsync(string cpf, CancellationToken cancellationToken);
        Task<Financiamento> InsertAsync(CreateFinanciamentoRequestDto financiamentoDto, CancellationToken cancellationToken);
        Task<Financiamento> UpdateAsync(UpdateFinanciamentoRequestDto financiamentoDto, CancellationToken cancellationToken);
    }
}
