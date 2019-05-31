using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class AdressConfiguration:EntityTypeConfiguration<Adress>
    {
        public AdressConfiguration()
        {
            this.ToTable(nameof(Adress));

            this.HasKey(x => x.ID);
            this.Property(x => x.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.CreatedAt).HasPrecision(3);
            this.Property(x => x.ChangeAt).HasPrecision(3);

            this.Property(x => x.Line1)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            this.Property(x => x.Line2)
                .HasMaxLength(50)
                .IsUnicode();

            this.Property(x => x.Town)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            this.Property(x => x.PostalCode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode();

            this.Property(x => x.Region)
                .HasMaxLength(50)
                .IsUnicode();

            this.Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();
        }
    }
}
