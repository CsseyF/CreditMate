using CreditMate.Application.Dtos.ClienteDtos;
using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Application.Services.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Core.Exceptions;

namespace CreditMate.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente>? FindOneAsync(Guid id,
            CancellationToken cancellationToken)
        {
            var entity = await _clienteRepository
                .FindOneAsync(id, cancellationToken);
            if(entity == null)
            {
                throw new EntityNotFoundException();
            }

            return entity;
        }
        public async Task<IEnumerable<Cliente>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await _clienteRepository.FindAllAsync(cancellationToken);

        }
        public async Task<Cliente> InsertAsync(CreateClienteRequestDto clienteDto,
            CancellationToken cancellationToken)
        {
            var entity = new Cliente()
            {
                Nome = clienteDto.Nome,
                Cpf = clienteDto.Cpf,
                Celular = clienteDto.Celular,
                Uf = clienteDto.Uf,

            };

            var existentEntity = _clienteRepository
                .FindByCpfAsync(clienteDto.Cpf, cancellationToken);

            if(existentEntity != null)
            {
                throw new AlreadyExistentException("Cpf");
            }

            var result = await _clienteRepository.InsertAsync(entity, cancellationToken);
            return result;
        }
        public async Task<Cliente> UpdateAsync(UpdateClienteRequestDto clienteDto,
            CancellationToken cancellationToken)
        {
            var oldEntity = await FindOneAsync(clienteDto.Id, cancellationToken);

            if(oldEntity == null)
            {
                throw new EntityNotFoundException(nameof(Cliente));
            }

            oldEntity.Nome = clienteDto?.Nome ?? oldEntity.Nome;
            oldEntity.Celular = clienteDto?.Celular ?? oldEntity.Celular;
            oldEntity.Cpf = clienteDto?.Cpf ?? oldEntity.Cpf;
            oldEntity.Uf = clienteDto?.Uf ?? oldEntity.Uf;
            oldEntity.UpdatedAt = DateTime.Now;

            return await _clienteRepository.UpdateAsync(oldEntity, cancellationToken);

        }
    }
}
