using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class actualityMap : EntityTypeConfiguration<actuality>
    {
        public actualityMap()
        {
            // Primary Key
            this.HasKey(t => t.idActuality);

            // Properties
            this.Property(t => t.idActuality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("actuality", "insurancedb");
            this.Property(t => t.idActuality).HasColumnName("idActuality");
        }
    }
}
