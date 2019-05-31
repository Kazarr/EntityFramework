using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class TransactionConfiguration:EntityTypeConfiguration<Transaction>
    {
        public TransactionConfiguration()
        {
            this.ToTable(nameof(Transaction));

            this.HasKey(x => x.ID);
            this.Property(x => x.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.CreatedAt).HasPrecision(3);
            this.Property(x => x.ChangeAt).HasPrecision(3);

            this.Property(x => x.Iban).IsRequired().HasMaxLength(24);
            this.Property(x => x.Bic).IsRequired().HasMaxLength(11);
            this.Property(x => x.Amount).HasPrecision(18, 2);
            this.Property(x => x.TransactionDate).HasPrecision(3);
            this.Property(x => x.OriginalAmount).HasPrecision(18, 2);
            this.Property(x => x.OriginalCurrency).HasMaxLength(3);
            this.Property(x => x.ExchangeRate).HasPrecision(12, 6);
        }
    }
}
