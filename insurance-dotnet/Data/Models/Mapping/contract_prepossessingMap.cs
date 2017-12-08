using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class contract_prepossessingMap : EntityTypeConfiguration<contract_prepossessing>
    {
        public contract_prepossessingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Contract_refContract, t.listPrepossessings_idPrepossessing });

            // Properties
            this.Property(t => t.Contract_refContract)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.listPrepossessings_idPrepossessing)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("contract_prepossessing", "insurancedb");
            this.Property(t => t.Contract_refContract).HasColumnName("Contract_refContract");
            this.Property(t => t.listPrepossessings_idPrepossessing).HasColumnName("listPrepossessings_idPrepossessing");
        }
    }
}
