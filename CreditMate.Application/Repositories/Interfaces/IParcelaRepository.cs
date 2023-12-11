using CreditMate.Core.Entities;

namespace CreditMate.Application.Repositories.Interfaces
{
    public interface IParcelaRepository
    {
        Task<Parcela>? FindOneAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Parcela>> FindAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<Parcela>> FindAllByFinanciamentoAsync(Guid financiamentoId, CancellationToken cancellationToken);
        Task<IEnumerable<Parcela>> InsertRangeAsync(IEnumerable<Parcela> parcelas, CancellationToken cancellationToken);
        Task<Parcela> UpdateAsync(Parcela parcela, CancellationToken cancellationToken);
    }
}
