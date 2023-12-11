using CreditMate.Application.Dtos.ClienteDtos;
using CreditMate.Core.Entities;

namespace CreditMate.Application.Services.Interfaces
{
    public interface IClienteService
    {
        Task<Cliente>? FindOneAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Cliente>> FindAllAsync(CancellationToken cancellationToken);
        Task<Cliente> InsertAsync(CreateClienteRequestDto clienteDto, CancellationToken cancellationToken);
        Task<Cliente> UpdateAsync(UpdateClienteRequestDto clienteDto, CancellationToken cancellationToken);
    }
}
