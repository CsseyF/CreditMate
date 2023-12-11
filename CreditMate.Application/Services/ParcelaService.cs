using CreditMate.Application.Dtos.ParcelaDtos;
using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Application.Services.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Core.Exceptions;

namespace CreditMate.Application.Services
{
    public class ParcelaService : IParcelaService
    {
        private readonly IParcelaRepository _parcelaRepository;

        public ParcelaService(IParcelaRepository parcelaRepository)
        {
            _parcelaRepository = parcelaRepository;
        }

        public async Task<Parcela>? FindOneAsync(Guid id,
            CancellationToken cancellationToken)
        {
            var entity = await _parcelaRepository.FindOneAsync(id, cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException();
            }

            return entity;
        }

        public async Task<IEnumerable<Parcela>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await _parcelaRepository.FindAllAsync(cancellationToken);
        }
        public async Task<IEnumerable<Parcela>> FindAllByFinanciamentoAsync(Guid financiamentoId,
            CancellationToken cancellationToken)
        {
            return await _parcelaRepository.FindAllByFinanciamentoAsync(financiamentoId, cancellationToken);
        }
        public async Task<IEnumerable<Parcela>> InsertRangeAsync(IEnumerable<Parcela> parcelas,
            CancellationToken cancellationToken)
        {
            if (!parcelas.Any())
            {
                throw new ArgumentNullException(nameof(parcelas));
            }

            var result = await _parcelaRepository.InsertRangeAsync(parcelas, cancellationToken);
            return result;
        }
        public async Task<Parcela> UpdateAsync(UpdateParcelaRequestDto parcelaDto,
            CancellationToken cancellationToken)
        {
            var oldEntity = await FindOneAsync(parcelaDto.Id, cancellationToken);

            if (oldEntity == null)
            {
                throw new EntityNotFoundException(nameof(Cliente));
            }
            oldEntity.DataPagamento = parcelaDto.DataPagamento;
            oldEntity.UpdatedAt = DateTime.Now;

            return await _parcelaRepository.UpdateAsync(oldEntity, cancellationToken);
        }
    }
}
