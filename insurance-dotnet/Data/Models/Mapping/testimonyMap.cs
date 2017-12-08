using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class testimonyMap : EntityTypeConfiguration<testimony>
    {
        public testimonyMap()
        {
            // Primary Key
            this.HasKey(t => t.idTestimony);

            // Properties
            this.Property(t => t.idTestimony)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Email)
                .HasMaxLength(255);

            this.Property(t => t.firstName)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("testimony", "insurancedb");
            this.Property(t => t.idTestimony).HasColumnName("idTestimony");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.phoneNumber).HasColumnName("phoneNumber");
            this.Property(t => t.claim_idClaim).HasColumnName("claim_idClaim");
        }
    }
}
