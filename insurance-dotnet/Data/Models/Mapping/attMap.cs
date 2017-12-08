using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models.Mapping
{
    public class attMap : EntityTypeConfiguration<att>
    {
        public attMap()
        {
            // Primary Key
            this.HasKey(t => t.idMatricule);

            // Properties
            this.Property(t => t.idMatricule)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("att", "insurancedb");
            this.Property(t => t.idMatricule).HasColumnName("idMatricule");
        }
    }
}
