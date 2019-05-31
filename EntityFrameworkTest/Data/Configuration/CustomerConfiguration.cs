using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class CustomerConfiguration:EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            this.ToTable(nameof(Customer));

            this.HasKey(x => x.ID);
            this.Property(x => x.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.CreatedAt).HasPrecision(3);
            this.Property(x => x.ChangeAt).HasPrecision(3);

            this.Property(x => x.GivenName)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode();

            this.Property(x => x.FamilyName)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode();

            this.Property(x => x.PersonalId)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(x => x.EmailAdress)
                .HasMaxLength(24);

            this.Property(x => x.PhoneNumber)
                .HasMaxLength(15);

            this.HasRequired(x => x.ResidentialAdress)
                .WithMany()
                .HasForeignKey(x => x.ResidentialAdressId)
                .WillCascadeOnDelete(false);

            this.HasOptional(x => x.PostalAdress)
                .WithMany()
                .HasForeignKey(x => x.PostalAdressId)
                .WillCascadeOnDelete(false);
        }
    }
}
