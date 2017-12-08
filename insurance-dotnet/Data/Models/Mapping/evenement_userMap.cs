using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class evenement_userMap : EntityTypeConfiguration<evenement_user>
    {
        public evenement_userMap()
        {
            // Primary Key
            this.HasKey(t => new { t.listEvents_EventID, t.participants_id });

            // Properties
            this.Property(t => t.listEvents_EventID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.participants_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("evenement_user", "insurancedb");
            this.Property(t => t.listEvents_EventID).HasColumnName("listEvents_EventID");
            this.Property(t => t.participants_id).HasColumnName("participants_id");
        }
    }
}
