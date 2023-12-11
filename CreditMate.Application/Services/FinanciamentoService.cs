using CreditMate.Application.Dtos.FinanciamentoDtos;
using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Application.Services.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Core.Exceptions;

namespace CreditMate.Application.Services
{
    public class FinanciamentoService : IFinanciamentoService
    {
        private readonly IFinanciamentoRepository _financiamentoRepository;
        private readonly IParcelaService _parcelaService;

        public FinanciamentoService(IFinanciamentoRepository financiamentoRepository, IParcelaService parcelaService)
        {
            _financiamentoRepository = financiamentoRepository;
            _parcelaService = parcelaService;

        }
        public async Task<Financiamento>? FindOneAsync(Guid id,
            CancellationToken cancellationToken)
        {
            // escrever adição das parcelas no retorno depois
            var entity = await _financiamentoRepository.FindOneAsync(id, cancellationToken);

            if(entity == null)
            {
                throw new EntityNotFoundException();
            }
            var parcelas = await _parcelaService.FindAllByFinanciamentoAsync(entity.Id, cancellationToken);
            entity.Parcelas = parcelas;

            return entity;
        }
        public async Task<IEnumerable<Financiamento>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await _financiamentoRepository.FindAllAsync(cancellationToken);
        }
        public async Task<IEnumerable<Financiamento>> FindAllByCpfAsync(string cpf,
            CancellationToken cancellationToken)
        {
            return await _financiamentoRepository.FindAllByCpfAsync(cpf, cancellationToken);
        }
        public async Task<Financiamento> InsertAsync(CreateFinanciamentoRequestDto financiamentoDto,
            CancellationToken cancellationToken)
        {
            if (financiamentoDto == null)
            {
                throw new ArgumentNullException(nameof(Financiamento));
            }

            var entity = new Financiamento()
            {
                Id = financiamentoDto.Id,
                Cpf = financiamentoDto.Cpf,
                TipoFinanciamento = financiamentoDto.TipoFinanciamento,
                UltimoVencimento = financiamentoDto.UltimoVencimento,
                ValorTotal = financiamentoDto.ValorTotal,
            };

            var result = await _financiamentoRepository.InsertAsync(entity, cancellationToken);
            return result;
        }
        public async Task<Financiamento> UpdateAsync(UpdateFinanciamentoRequestDto financiamentoDto,
            CancellationToken cancellationToken)
        {
            var oldEntity = await FindOneAsync(financiamentoDto.Id, cancellationToken);

            if (oldEntity == null)
            {
                throw new EntityNotFoundException(nameof(Cliente));
            }
            oldEntity.Cpf = financiamentoDto?.Cpf;
            oldEntity.UpdatedAt = DateTime.Now;

            return await _financiamentoRepository.UpdateAsync(oldEntity, cancellationToken);
        }
    }
}
