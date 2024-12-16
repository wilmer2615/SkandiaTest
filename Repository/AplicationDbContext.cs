using DataTransferObjects;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<NaturalPerson> NaturalPersons { get; set; }
        public DbSet<LegalPerson> LegalPersons { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<ShareholdingComposition> ShareholdingCompositions { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<CreditCardTransaction> CreditCardTransactions { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<SavingsAccountHolder> SavingsAccountHolders { get; set; }
        public DbSet<SavingsAccountTransaction> SavingsAccountTransactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<ExchangeTransactionState> ExchangeTransactionStates { get; set; }
        public DbSet<TransactionsCreditCardType> TransactionsCreditCardTypes { get; set; }
        public DbSet<Franchise> Franchise { get; set; }


        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FranchiseDebt>().ToTable("FranchiseDebt", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<AccountMoreHeadlines>().ToTable("AccountMoreHeadlines", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<CustomerAccountBalance>().ToTable("CustomerAccountBalance", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<HighestBalanceExchange>().ToTable("HighestBalanceExchange", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<HighestWithdrawnBalance>().ToTable("HighestWithdrawnBalance", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<NumberActiveForeignAccounts>().ToTable("ActiveForeignAccounts", t => t.ExcludeFromMigrations());
            modelBuilder.Entity<CustomerAccountBalance>().ToTable("TotalDebtBalanceShareholders", t => t.ExcludeFromMigrations());

            // Datos semilla para Departamento
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Antioquia" },
                new Department { Id = 2, Name = "Cundinamarca" }
            );

            // Datos semilla para Municipio
            modelBuilder.Entity<Municipality>().HasData(
                new Municipality { Id = 1, Name = "Medellín " },
                new Municipality { Id = 2, Name = "Envigado" },
                new Municipality { Id = 3, Name = "Bogotá  " },
                new Municipality { Id = 4, Name = "Soacha" }
            );

            // Datos semilla para Nacionalidad
            modelBuilder.Entity<Nationality>().HasData(
                new Nationality { Id = 1, Name = "Colombiana" },
                new Nationality { Id = 2, Name = "Americana" }
            );

            // Datos semilla para tipos de transacción
            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType { Id = 1, Description = "DepositoEfectivo" },
                new TransactionType { Id = 2, Description = "DepositoCheque" },
                new TransactionType { Id = 3, Description = "Retiro" }
            );

            // Datos semilla para tipos de transacción en canje
            modelBuilder.Entity<ExchangeTransactionState>().HasData(
                new ExchangeTransactionState { Id = 1, Description = "Validacion" },
                new ExchangeTransactionState { Id = 2, Description = "Aprobado" },
                new ExchangeTransactionState { Id = 3, Description = "Rechazado" }
            );

            // Datos semilla para tipos de transacción tarjeta de credito
            modelBuilder.Entity<TransactionsCreditCardType>().HasData(
                new TransactionsCreditCardType { Id = 1, Description = "ComprasNacionales" },
                new TransactionsCreditCardType { Id = 2, Description = "CuotaManejo" },
                new TransactionsCreditCardType { Id = 3, Description = "PagoTarjeta" },
                new TransactionsCreditCardType { Id = 4, Description = "RetirosAvance" }
            );

            // Datos semilla para Franquicia
            modelBuilder.Entity<Franchise>().HasData(
                new Franchise { Id = 1, Description = "Visa" },
                new Franchise { Id = 2, Description = "MasterCard" },
                new Franchise { Id = 3, Description = "AmericanExpress" },
                new Franchise { Id = 4, Description = "Diners" }
            );

            // Relación entre NaturalPerson y Department
            modelBuilder.Entity<NaturalPerson>()
                .HasOne(np => np.Department)
                .WithMany(d => d.NaturalPersons)
                .HasForeignKey(np => np.DepartmentId);

            // Relación entre NaturalPerson y Municipality
            modelBuilder.Entity<NaturalPerson>()
                .HasOne(np => np.Municipality)
                .WithMany(m => m.NaturalPersons)
                .HasForeignKey(np => np.MunicipalityId);

            // Relación entre NaturalPerson y Nationality 
            modelBuilder.Entity<NaturalPerson>()
                .HasOne(np => np.Nationality)
                .WithMany(n => n.NaturalPersons)
                .HasForeignKey(np => np.NationalityId);

            // Relación entre PersonRole y Role 
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Role)
                .WithMany(r => r.PersonRoles)
                .HasForeignKey(pr => pr.RoleId);

            // Relación entre PersonRole y NaturalPerson
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.NaturalPerson)
                .WithMany(np => np.PersonRoles)
                .HasForeignKey(pr => pr.PersonId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relación entre PersonRole y LegalPerson
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.LegalPerson)
                .WithMany(lp => lp.PersonRoles)
                .HasForeignKey(pr => pr.PersonId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PersonRole>()
                .Property(pr => pr.PersonType)
                .HasMaxLength(50)
                .IsRequired();

            // Relación entre LegalPerson y NaturalPerson 
            modelBuilder.Entity<LegalPerson>()
               .HasOne(lp => lp.LegalRepresentative)
               .WithMany(np => np.LegalPersons)
               .HasForeignKey(lp => lp.LegalRepresentativeId);

            // Relación entre ShareholdingComposition y LegalPerson
            modelBuilder.Entity<ShareholdingComposition>()
                .HasOne(sc => sc.Company)
                .WithMany()
                .HasForeignKey(sc => sc.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relación entre ShareholdingComposition y NaturalPerson
            modelBuilder.Entity<ShareholdingComposition>()
                .HasOne(sc => sc.ShareholderNatural)
                .WithMany()
                .HasForeignKey(sc => sc.ShareholderId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relación entre SavingsAccountHolder y NaturalPerson
            modelBuilder.Entity<SavingsAccountHolder>()
                .HasOne(sh => sh.NaturalPerson)
                .WithMany(np => np.SavingsAccountHolders)
                .HasForeignKey(sh => sh.PersonId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);

            // Relación entre SavingsAccount y SavingsAccountTransaction
            modelBuilder.Entity<SavingsAccountTransaction>()
                .HasOne(st => st.SavingsAccount)
                .WithMany(sa => sa.Transactions)
                .HasForeignKey(st => st.SavingsAccountId);

            // Relación entre TransactionType y SavingsAccountTransaction
            modelBuilder.Entity<SavingsAccountTransaction>()
                .HasOne(st => st.TransactionType)
                .WithMany(tp => tp.Transactions)
                .HasForeignKey(st => st.TransactionTypeId);

            // Relación entre ExchangeTransactionState y SavingsAccountTransaction
            modelBuilder.Entity<SavingsAccountTransaction>()
                .HasOne(st => st.ExchangeTransactionState)
                .WithMany(ts => ts.Transactions)
                .HasForeignKey(st => st.ExchangeTransactionStateId);

            // Relación entre CreditCard y Person
            modelBuilder.Entity<CreditCard>()
                .HasOne(cc => cc.Person)
                .WithMany(p => p.CreditCards)
                .HasForeignKey(cc => cc.PersonId);

            // Relación entre CreditCard y Franquicia
            modelBuilder.Entity<CreditCard>()
                .HasOne(cc => cc.Franchise)
                .WithMany(p => p.CreditCards)
                .HasForeignKey(cc => cc.FranchiseId);

            // Relación entre CreditCard y CreditCardTransaction
            modelBuilder.Entity<CreditCardTransaction>()
                .HasOne(ct => ct.CreditCard)
                .WithMany(cc => cc.Transactions)
                .HasForeignKey(ct => ct.CreditCardId);

            // Relación entre TransactionsCreditCardType y CreditCardTransaction
            modelBuilder.Entity<CreditCardTransaction>()
                .HasOne(ct => ct.TransactionsCreditCardType)
                .WithMany(cc => cc.Transactions)
                .HasForeignKey(ct => ct.TransactionCreditCardTypeId);

           
            // Configurar la longitud máxima de los campos
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<NaturalPerson>()
                .Property(np => np.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<LegalPerson>()
                .Property(lp => lp.CompanyName)
                .HasMaxLength(200);


            modelBuilder.Entity<NaturalPerson>()
                .Property(np => np.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<NaturalPerson>()
                .Property(np => np.LastName)
                .HasMaxLength(100);

            modelBuilder.Entity<Department>()
                .Property(d => d.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Municipality>()
                .Property(m => m.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Nationality>()
                .Property(n => n.Name)
                .HasMaxLength(100);
        }

    }
}
