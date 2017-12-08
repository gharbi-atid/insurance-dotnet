using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models.Mapping
{
    public class contract_claimMap : EntityTypeConfiguration<contract_claim>
    {
        public contract_claimMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Contract_refContract, t.listClaims_idClaim });

            // Properties
            this.Property(t => t.Contract_refContract)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.listClaims_idClaim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("contract_claim", "insurancedb");
            this.Property(t => t.Contract_refContract).HasColumnName("Contract_refContract");
            this.Property(t => t.listClaims_idClaim).HasColumnName("listClaims_idClaim");
        }
    }
}
