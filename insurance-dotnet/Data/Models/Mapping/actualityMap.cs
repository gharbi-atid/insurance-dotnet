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

            this.Property(t => t.titre)
              .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);





            // Table & Column Mappings
            this.ToTable("actuality", "insurancedb");
            this.Property(t => t.idActuality).HasColumnName("idActuality");
            this.Property(t => t.titre).HasColumnName("titre");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.date).HasColumnName("Date");
        }
    }
}
