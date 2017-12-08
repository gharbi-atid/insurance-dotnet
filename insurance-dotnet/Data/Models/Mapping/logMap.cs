using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class logMap : EntityTypeConfiguration<log>
    {
        public logMap()
        {
            // Primary Key
            this.HasKey(t => t.idLog);

            // Properties
            this.Property(t => t.idLog)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("log", "insurancedb");
            this.Property(t => t.idLog).HasColumnName("idLog");
        }
    }
}
