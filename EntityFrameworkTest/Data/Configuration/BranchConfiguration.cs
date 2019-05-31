using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class BranchConfiguration:EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            this.ToTable(nameof(Branch));

            this.HasKey(x => x.ID);
            this.Property(x => x.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(x => x.CreatedAt).HasPrecision(3);
            this.Property(x => x.ChangeAt).HasPrecision(3);

            this.Property(x => x.BranchCode).IsRequired().HasMaxLength(10);
            this.Property(x => x.Name).IsRequired().HasMaxLength(50).IsUnicode();

            this.HasRequired<Adress>(x => x.Adress)
                .WithMany()
                .HasForeignKey(x => x.AdressId)
                .WillCascadeOnDelete(false);
        }
    }
}
