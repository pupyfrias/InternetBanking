using InternetBanking.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternetBanking.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Beneficiary> Beneficiaries {get; set;}
        public DbSet<CashAdvance>  CashAdvances {get; set; }
        public DbSet<CreditCard> CreditCards  {get; set; }
        public DbSet<Loan> Loans {get; set; }
        public DbSet<Payment> Payments {get; set; }
        public DbSet<Product>  Products {get; set; }
        public DbSet<Transaction> Transactions {get; set; }
        public DbSet<Client> Clients {get; set; }
        public DbSet<ProductType> ProductTypes {get; set; }
        public DbSet<Account> Accounts {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Client
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");
                
                entity.HasKey(e=> e.Id)
                .HasName("PK_Client");
                
                entity.Property(e => e.Name)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            });
            #endregion

            #region Beneficiary
            modelBuilder.Entity<Beneficiary>(entity =>
            {
                entity.ToTable("Beneficiary");

                entity.HasKey(e=> e.Id).HasName("PK_Beneficiary");

                //FOREIGNKEYS
                entity.HasOne(e => e.Client)
                .WithMany(e => e.Beneficiaries)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.ClientBeneficiary)
               .WithMany(e => e.ClientsBeneficiaries)
               .HasForeignKey(e => e.BeneficiaryId)
               .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region CashAdvance
            modelBuilder.Entity<CashAdvance>(entity =>
            {
                entity.ToTable("CashAdvance");
                entity.HasKey(e=> e.Id).HasName("PK_CashAdvance");
                
                entity.Property(e => e.Amount)
                .HasColumnType("DECIMAL(13,2)")
                .IsRequired();

                entity.Property(e => e.InterestRate)
                .HasColumnType("DECIMAL(3,2)")
                .IsRequired();

                //FOREIGNKEYS
                entity.HasOne(e => e.Client)
                .WithMany(e => e.CashAdvances)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.Account)
                .WithMany(e => e.CashAdvances)
                .HasForeignKey(e => e.DestinationAccountId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.CreditCard)
                .WithMany(e => e.CashAdvances)
                .HasForeignKey(e => e.CreditCardId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region CreditCard
            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.ToTable("CreditCard");
                entity.HasKey(e=> e.Id).HasName("PK_CreditCard");
                
                entity.Property(e => e.Limit)
                .HasColumnType("DECIMAL(13,2)");

                entity.Property(e => e.AvalableBalance)
                .HasColumnType("DECIMAL(13,2)");

                entity.Property(e => e.BalanceToDate)
                .HasColumnType("DECIMAL(13,2)");

                //FOREIGNKEYS

                entity.HasOne(e => e.Product)
                 .WithOne(e => e.CreditCard)
                 .HasForeignKey<CreditCard>(e => e.ProductId)
                 .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.Client)
                .WithMany(e => e.CreditCards)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region Loan
            modelBuilder.Entity<Loan>(entity =>
            {
                entity.ToTable("Loan");
                entity.HasKey(e=> e.Id).HasName("PK_Loan");
                
                entity.Property(e => e.InterestRate)
                .HasColumnType("DECIMAL(13,2)")
                .IsRequired();

                entity.Property(e => e.BalanceSettled)
                .HasColumnType("DECIMAL(13,2)")
                .IsRequired();

                entity.Property(e => e.OutstandingBalace)
                .HasColumnType("DECIMAL(13,2)")
                .IsRequired();

                entity.Property(e => e.AmountApproved)
                .HasColumnType("DECIMAL(13,2)")
                .IsRequired();

                //FOREIGNKEYS
                entity.HasOne(e => e.Product)
                 .WithOne(e => e.Loan)
                 .HasForeignKey<Loan>(e => e.ProductId)
                 .OnDelete(DeleteBehavior.NoAction);
                
                entity.HasOne(e => e.Client)
                .WithMany(e => e.Loans)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.Account)
                .WithMany(e => e.Loans)
                .HasForeignKey(e => e.DestinationAccountId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region Payment
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");
                entity.HasKey(e=> e.Id).HasName("PK_Payment");
                
                entity.Property(e => e.Amount)
                .HasColumnType("DECIMAL(13,2)");

                entity.Property(e => e.Description)
                .HasColumnType("VARCHAR(MAX)");

                //FOREIGNKEYS
                entity.HasOne(e => e.Client)
                .WithMany(e => e.Payments)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.OriginAccount)
               .WithMany(e => e.PaymentsOriginAccount)
               .HasForeignKey(e => e.OriginAccountId)
               .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.DestinationAccount)
               .WithMany(e => e.PaymentsDestinationAccount)
               .HasForeignKey(e => e.DestinationAccountId)
               .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(e=> e.Id).HasName("PK_Product");

                //FOREIGNKEYS
                entity.HasOne(e => e.Client)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion 

            #region Account
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");
                entity.HasKey(e=> e.Id).HasName("PK_Account");
                
                entity.Property(e => e.Balance)
                .HasColumnType("DECIMAL(13,2)");

                //FOREIGNKEYS
                entity.HasOne(e => e.Client)
                .WithMany(e => e.Accounts)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.Product)
                .WithOne(e => e.Account)
                .HasForeignKey<Account>(e=> e.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region ProductType
            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("ProductType");
                entity.HasKey(e=> e.Id).HasName("PK_ProductType");
                
                entity.Property(e => e.Name)
                .HasColumnType("VARCHAR(50)");

                entity.HasMany(e => e.Product)
                .WithOne(e => e.ProductType)
                .HasForeignKey(e => e.ProductTypeId);

            });
            #endregion

            #region Transaction
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");
                entity.HasKey(e=> e.Id).HasName("PK_Transaction");

                entity.Property(e => e.Amount)
                .HasColumnType("DECIMAL(13,2)")
                .IsRequired();

                entity.Property(e => e.Description)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

                //FOREIGNKEYS
                entity.HasOne(e => e.Client)
                .WithMany(e => e.Transactions)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.Product)
               .WithMany(e => e.Transactions)
               .HasForeignKey(e => e.ProductId)
               .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.OriginAccount)
               .WithMany(e => e.TransactionsOriginAccount)
               .HasForeignKey(e => e.OriginAccountId)
               .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.DestinationAccount)
                .WithMany(e => e.TransactionsDestinationAccount)
                .HasForeignKey(e => e.DestinationAccountId)
                .OnDelete(DeleteBehavior.NoAction);

            });
            #endregion
        }
    }
}
