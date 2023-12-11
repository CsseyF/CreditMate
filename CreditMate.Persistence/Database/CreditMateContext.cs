using Microsoft.EntityFrameworkCore;
using CreditMate.Core.Entities;
using CreditMate.Core.Enums;

namespace CreditMate.Persistence.Database
{
    public class CreditMateContext : DbContext
    {
        public CreditMateContext(DbContextOptions<CreditMateContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Financiamento> Financiamento { get; set; }
        public DbSet<Parcela> Parcela { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasQueryFilter(x => x.IsActive);

            modelBuilder.Entity<Cliente>()
                .HasMany(x => x.Financiamentos);

            modelBuilder.Entity<Cliente>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Cliente>()
                .Property(x => x.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Cliente>()
                .Property(x => x.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Cliente>()
                .Property(x => x.IsActive)
                .HasDefaultValue(true);

            modelBuilder.Entity<Financiamento>()
                .HasQueryFilter(x => x.IsActive);

            modelBuilder.Entity<Financiamento>()
             .HasMany(x => x.Parcelas);

            modelBuilder.Entity<Financiamento>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Financiamento>()
                .Property(x => x.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Financiamento>()
                .Property(x => x.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Financiamento>()
                .Property(x => x.IsActive)
                .HasDefaultValue(true);

            modelBuilder.Entity<Parcela>()
                .HasQueryFilter(x => x.IsActive);

            modelBuilder.Entity<Parcela>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Parcela>()
                .Property(x => x.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Parcela>()
                .Property(x => x.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Parcela>()
                .Property(x => x.IsActive)
                .HasDefaultValue(true);



            //Seeding
            //Cliente
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = Guid.Parse("a1f2565e-d7e6-4170-9b35-7d1228ea55f1"),
                    Nome = "Casey Adesola Fernandes",
                    Cpf = "38586555894",
                    Celular = "(11)951136376",
                    Uf = "SP",
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = Guid.Parse("a26635ef-b924-4a97-873e-26c2801d323a"),
                    Nome = "Lucas Amorim",
                    Cpf = "53119013064",
                    Celular = "(27)989000360",
                    Uf = "SP",
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });

            modelBuilder.Entity<Cliente>().HasData(
                 new Cliente()
                 {
                     Id = Guid.Parse("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                     Nome = "Douglas Eduardo",
                     Cpf = "53546002512",
                     Celular = "(45)996176307",
                     Uf = "SP",
                     IsActive = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 });

            modelBuilder.Entity<Cliente>().HasData(
                 new Cliente()
                 {
                    Id = Guid.Parse("f312357b-6f1a-494d-9425-6cbc3f4ad9a7"),
                    Nome = "Guilherme Barros",
                    Cpf = "27310180038",
                    Celular = "(21)987646298",
                    Uf = "RJ",
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                 });

            //Financiamento
            modelBuilder.Entity<Financiamento>().HasData(
                 new Financiamento()
                 {
                     Id = Guid.Parse("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                     Cpf = "38586555894",
                     TipoFinanciamento = TipoFinanciamentoEnum.Direto,
                     UltimoVencimento = DateTime.Now.AddMonths(6),
                     ValorTotal = 50000,
                     IsActive = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 });

            modelBuilder.Entity<Financiamento>().HasData(
                 new Financiamento()
                 {
                     Id = Guid.Parse("abc3a4f6-ea22-4523-9915-f13a5f5e6253"),
                     Cpf = "53119013064",
                     TipoFinanciamento = TipoFinanciamentoEnum.Consignado,
                     UltimoVencimento = DateTime.Now.AddMonths(24),
                     ValorTotal = 800000,
                     IsActive = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 });

            modelBuilder.Entity<Financiamento>().HasData(
                new Financiamento()
                {
                    Id = Guid.Parse("aa77cc25-111c-4011-9d27-bd630a32753f"),
                    Cpf = "53546002512",
                    TipoFinanciamento = TipoFinanciamentoEnum.PF,
                    UltimoVencimento = DateTime.Now.AddMonths(12),
                    ValorTotal = 200000,
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });

            //Parcela
            modelBuilder.Entity<Parcela>().HasData(
                 new Parcela()
                 {
                     Id = Guid.Parse("cbfc78b8-8651-4c3a-b1f3-495d35372526"),
                     DataPagamento = null,
                     DataVencimento = DateTime.Now.AddDays(20),
                     FinanciamentoId = Guid.Parse("f35c557b-6f1a-494d-9425-69fc3f4ed9a7"),
                     NumeroParcela = 1,
                     Valor = 8333,
                     IsActive = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 });

            modelBuilder.Entity<Parcela>().HasData(
                 new Parcela()
                 {
                     Id = Guid.Parse("f96444c8-e822-43eb-ae1d-6531c2374ae2"),
                     DataPagamento = null,
                     DataVencimento = DateTime.Now.AddDays(20),
                     FinanciamentoId = Guid.Parse("abc3a4f6-ea22-4523-9915-f13a5f5e6253"),
                     NumeroParcela = 1,
                     Valor = 3333,
                     IsActive = true,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                 });

            modelBuilder.Entity<Parcela>().HasData(
                  new Parcela()
                  {
                      Id = Guid.Parse("7eb2d084-8fad-4078-856b-8f60658d860e"),
                      DataPagamento = null,
                      DataVencimento = DateTime.Now.AddDays(20),
                      FinanciamentoId = Guid.Parse("aa77cc25-111c-4011-9d27-bd630a32753f"),
                      NumeroParcela = 1,
                      Valor = 1666,
                      IsActive = true,
                      CreatedAt = DateTime.Now,
                      UpdatedAt = DateTime.Now,
                  });

            base.OnModelCreating(modelBuilder);
        }
    }
}
