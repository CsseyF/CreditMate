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

            modelBuilder.Entity<BaseEntity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<BaseEntity>()
                .Property(x => x.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<BaseEntity>()
                .Property(x => x.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<BaseEntity>()
                .Property(x => x.IsActive)
                .HasDefaultValue(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
