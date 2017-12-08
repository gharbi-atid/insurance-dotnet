using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class policeMap : EntityTypeConfiguration<police>
    {
        public policeMap()
        {
            // Primary Key
            this.HasKey(t => t.idPolice);

            // Properties
            this.Property(t => t.idPolice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.classe)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("police", "insurancedb");
            this.Property(t => t.idPolice).HasColumnName("idPolice");
            this.Property(t => t.contract_refContract).HasColumnName("contract_refContract");
            this.Property(t => t.classe).HasColumnName("classe");
        }
    }
}
