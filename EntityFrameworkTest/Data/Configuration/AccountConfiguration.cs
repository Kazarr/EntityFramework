using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Configuration
{
    public class AccountConfiguration:EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            this.ToTable(nameof(Account));
            this.HasKey(x => x.ID);
            this.Property(x => x.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.CreatedAt).HasPrecision(3);
            this.Property(x => x.ChangeAt).HasPrecision(3);

            this.Property(x => x.Iban).HasMaxLength(34).IsRequired();
            this.HasIndex(x => x.Iban).IsUnique();

            this.Property(x => x.Name).HasMaxLength(24).IsRequired();
            this.Property(x => x.Balance).HasPrecision(18, 2);
            this.Property(x => x.Reservations).HasPrecision(18, 2);
            this.Property(x => x.OverdrafLimit).HasPrecision(18, 2);
            this.Property(x => x.Bic).HasMaxLength(11).IsRequired();
            this.Property(x => x.Currency).HasMaxLength(3).IsRequired();

            this.Property(x => x.Opened).HasColumnType("date");
            this.Property(x => x.Closed).HasColumnType("date");

            this.HasRequired<Branch>(x => x.Branch)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.BranchId)
                .WillCascadeOnDelete(false);

            //many to many
            this.HasMany<Customer>(x => x.Owners)
                .WithMany(x => x.OwnAccounts)
                .Map(x =>
                {
                    x.MapLeftKey($"{nameof(Account)}{nameof(Account.ID)}");
                    x.MapRightKey($"{nameof(Customer)}{nameof(Customer.ID)}");
                    x.ToTable($"{nameof(Account)}Owner");
                });
            this.HasMany<Customer>(x => x.Disponents)
                .WithMany(x => x.DisponibleAccounts)
                .Map(x =>
                {
                    x.MapLeftKey($"{nameof(Account)}{nameof(Account.ID)}");
                    x.MapRightKey($"{nameof(Customer)}{nameof(Customer.ID)}");
                    x.ToTable($"{nameof(Account)}Disponent");
                });

        }
    }
}
