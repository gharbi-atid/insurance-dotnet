using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class surveyvoteMap : EntityTypeConfiguration<surveyvote>
    {
        public surveyvoteMap()
        {
            // Primary Key
            this.HasKey(t => t.idSurveyVote);

            // Properties
            this.Property(t => t.idSurveyVote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.vote)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("surveyvote", "insurancedb");
            this.Property(t => t.idSurveyVote).HasColumnName("idSurveyVote");
            this.Property(t => t.insured_cin).HasColumnName("insured_cin");
            this.Property(t => t.survey_idSurvey).HasColumnName("survey_idSurvey");
            this.Property(t => t.insured_id).HasColumnName("insured_id");
            this.Property(t => t.vote).HasColumnName("vote");
        }
    }
}
