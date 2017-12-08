using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class actualitycommentMap : EntityTypeConfiguration<actualitycomment>
    {
        public actualitycommentMap()
        {
            // Primary Key
            this.HasKey(t => t.idActualityComment);

            // Properties
            this.Property(t => t.idActualityComment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("actualitycomment", "insurancedb");
            this.Property(t => t.idActualityComment).HasColumnName("idActualityComment");
            this.Property(t => t.actuality_idActuality).HasColumnName("actuality_idActuality");
            this.Property(t => t.insured_cin).HasColumnName("insured_cin");
            this.Property(t => t.insured_id).HasColumnName("insured_id");
        }
    }
}
