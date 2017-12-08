using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class surveyMap : EntityTypeConfiguration<survey>
    {
        public surveyMap()
        {
            // Primary Key
            this.HasKey(t => t.idSurvey);

            // Properties
            this.Property(t => t.idSurvey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("survey", "insurancedb");
            this.Property(t => t.idSurvey).HasColumnName("idSurvey");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.endDate).HasColumnName("endDate");
            this.Property(t => t.status).HasColumnName("status");
        }
    }
}
