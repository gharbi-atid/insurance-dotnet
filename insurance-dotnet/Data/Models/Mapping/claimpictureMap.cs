using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models.Mapping
{
    public class claimpictureMap : EntityTypeConfiguration<claimpicture>
    {
        public claimpictureMap()
        {
            // Primary Key
            this.HasKey(t => t.name);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("claimpicture", "insurancedb");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.claim_idClaim).HasColumnName("claim_idClaim");
        }
    }
}
