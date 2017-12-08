using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class reunion_userMap : EntityTypeConfiguration<reunion_user>
    {
        public reunion_userMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Reunion_idReunion, t.listInvitedEmployees_cin, t.listReunions_idReunion, t.listInvitedEmployees_id });

            // Properties
            this.Property(t => t.Reunion_idReunion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.listInvitedEmployees_cin)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.listReunions_idReunion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.listInvitedEmployees_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("reunion_user", "insurancedb");
            this.Property(t => t.Reunion_idReunion).HasColumnName("Reunion_idReunion");
            this.Property(t => t.listInvitedEmployees_cin).HasColumnName("listInvitedEmployees_cin");
            this.Property(t => t.listReunions_idReunion).HasColumnName("listReunions_idReunion");
            this.Property(t => t.listInvitedEmployees_id).HasColumnName("listInvitedEmployees_id");
        }
    }
}
