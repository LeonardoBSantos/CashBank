using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DigitalAccountContext : DbContext
    {
        public DigitalAccountContext(DbContextOptions<DigitalAccountContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClientId);
                entity.Property(e => e.ClientId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.HasKey(d => d.WalletId);
                entity.Property(d => d.WalletId).ValueGeneratedOnAdd();
                entity.Property(d => d.WalletAmount).HasDefaultValue(0);

                entity.HasOne(d => d.Client)
                    .WithOne()
                    .HasForeignKey<Wallet>(d => d.FkClientId);    
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.OperationType).IsUnicode(false);
                entity.Property(e => e.TransactionId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Wallet)
                    .WithMany()
                    .HasForeignKey(d => d.FkWalletId);
            });
        }
    }
}
