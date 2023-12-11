using Microsoft.EntityFrameworkCore;
using CreditMate.Core.Entities;

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

            base.OnModelCreating(modelBuilder);
        }
    }
}
