using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditMate.Application.Repositories
{
    public class ParcelaRepository : IParcelaRepository
    {
        private readonly CreditMateContext _context;

        public ParcelaRepository(CreditMateContext context)
        {
            _context = context;
        }

        public async Task<Parcela>? FindOneAsync(Guid id,
            CancellationToken cancellationToken)
        {
            return await _context.Parcela
                 .IgnoreQueryFilters()
                .FirstOrDefaultAsync(record => record.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<Parcela>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Parcela.ToListAsync(cancellationToken);
        }
        public async Task<IEnumerable<Parcela>> FindAllByFinanciamentoAsync(Guid financiamentoId,
            CancellationToken cancellationToken)
        {
            return await _context.Parcela
                .Where(record => record.FinanciamentoId == financiamentoId)
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Parcela>> InsertRangeAsync(IEnumerable<Parcela> parcelas,
            CancellationToken cancellationToken)
        {
            await _context.Parcela
                .AddRangeAsync(parcelas, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return parcelas;
        }
        public async Task<Parcela> UpdateAsync(Parcela parcela,
            CancellationToken cancellationToken)
        {
            _context.Parcela.Entry(parcela).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);

            return parcela;
        }
    }
}
