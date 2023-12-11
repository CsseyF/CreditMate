using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Core.Entities;
using CreditMate.Persistence.Database;
using Microsoft.EntityFrameworkCore;

namespace CreditMate.Application.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CreditMateContext _context;
        public ClienteRepository(CreditMateContext context)
        {
            _context = context;
        }

        public async Task<Cliente>? FindOneAsync(Guid id,
            CancellationToken cancellationToken)
        {
            return await _context.Cliente
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(record => record.Id == id, cancellationToken);
        }
        public async Task<IEnumerable<Cliente>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Cliente.ToListAsync(cancellationToken);
        }

        public async Task<Cliente> FindByCpfAsync(string cpf, CancellationToken cancellationToken)
        {
            return await _context.Cliente
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(record => record.Cpf == cpf, cancellationToken);
        }
        public async Task<Cliente> InsertAsync(Cliente cliente,
            CancellationToken cancellationToken)
        {
            var entity = await _context.Cliente
                .AddAsync(cliente, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Entity;
        }

        public async Task<Cliente> UpdateAsync(Cliente cliente,
            CancellationToken cancellationToken)
        {
            _context.Cliente.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);

            return cliente;
        }

    }
}
