using CreditMate.Core.Entities;

namespace CreditMate.Application.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente>? FindOneAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Cliente>> FindAllAsync(CancellationToken cancellationToken);
        Task<Cliente> InsertAsync(Cliente cliente, CancellationToken cancellationToken);
        Task<Cliente> UpdateAsync(Cliente cliente, CancellationToken cancellationToken);
    }
}
