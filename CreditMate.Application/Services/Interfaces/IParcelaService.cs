using CreditMate.Application.Dtos.ParcelaDtos;
using CreditMate.Core.Entities;

namespace CreditMate.Application.Services.Interfaces
{
    public interface IParcelaService
    {
        Task<Parcela>? FindOneAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Parcela>> FindAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<Parcela>> FindAllByFinanciamentoAsync(Guid financiamentoId, CancellationToken cancellationToken);
        Task<IEnumerable<Parcela>> InsertRangeAsync(IEnumerable<Parcela> parcelas, CancellationToken cancellationToken);
        Task<Parcela> UpdateAsync(UpdateParcelaRequestDto parcelaDto, CancellationToken cancellationToken);
    }
}
