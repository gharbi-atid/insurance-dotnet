using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class reclamationMap : EntityTypeConfiguration<reclamation>
    {
        public reclamationMap()
        {
            // Primary Key
            this.HasKey(t => t.idReclamation);

            // Properties
            this.Property(t => t.idReclamation)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reclamation", "insurancedb");
            this.Property(t => t.idReclamation).HasColumnName("idReclamation");
            this.Property(t => t.insured_cin).HasColumnName("insured_cin");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.insured_id).HasColumnName("insured_id");
            this.Property(t => t.dateTime).HasColumnName("dateTime");
        }
    }
}
