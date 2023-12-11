using CreditMate.Core.Entities;

namespace CreditMate.Application.Repositories.Interfaces
{
    public interface IFinanciamentoRepository
    {
        Task<Financiamento>? FindOneAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Financiamento>> FindAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<Financiamento>> FindAllByCpfAsync(string cpf, CancellationToken cancellationToken);
        Task<Financiamento> InsertAsync(Financiamento financiamento, CancellationToken cancellationToken);
        Task<Financiamento> UpdateAsync(Financiamento financiamento, CancellationToken cancellationToken);
    }
}
