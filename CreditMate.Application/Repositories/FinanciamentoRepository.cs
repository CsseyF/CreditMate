using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Persistence.Database;
using Microsoft.EntityFrameworkCore;

namespace CreditMate.Application.Repositories
{
    public class FinanciamentoRepository : IFinanciamentoRepository
    {
        private readonly CreditMateContext _context;
        public FinanciamentoRepository(CreditMateContext context)
        {
            _context = context;
        }
        public async Task<Financiamento>? FindOneAsync(Guid id,
            CancellationToken cancellationToken)
        {
            return await _context.Financiamento
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(record => record.Id == id, cancellationToken);

        }
        public async Task<IEnumerable<Financiamento>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Financiamento.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Financiamento>> FindAllByCpfAsync(string cpf,
            CancellationToken cancellationToken)
        {
            return await _context.Financiamento
                .Where(record => record.Cpf == cpf)
                .ToListAsync(cancellationToken);
        }
        public async Task<Financiamento> InsertAsync(Financiamento financiamento,
            CancellationToken cancellationToken)
        {
            var entity = await _context.Financiamento
                .AddAsync(financiamento, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Entity;
        }
        public async Task<Financiamento> UpdateAsync(Financiamento financiamento,
            CancellationToken cancellationToken)
        {
            _context.Financiamento.Entry(financiamento).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);

            return financiamento;
        }
    }
}
