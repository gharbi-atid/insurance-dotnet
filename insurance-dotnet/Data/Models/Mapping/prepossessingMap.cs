using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class prepossessingMap : EntityTypeConfiguration<prepossessing>
    {
        public prepossessingMap()
        {
            // Primary Key
            this.HasKey(t => t.idPrepossessing);

            // Properties
            this.Property(t => t.idPrepossessing)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("prepossessing", "insurancedb");
            this.Property(t => t.idPrepossessing).HasColumnName("idPrepossessing");
            this.Property(t => t.contract_refContract).HasColumnName("contract_refContract");
        }
    }
}
