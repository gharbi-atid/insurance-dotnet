using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models.Mapping
{
    public class appointmentMap : EntityTypeConfiguration<appointment>
    {
        public appointmentMap()
        {
            // Primary Key
            this.HasKey(t => t.idAppointment);

            // Properties
            this.Property(t => t.idAppointment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("appointment", "insurancedb");
            this.Property(t => t.idAppointment).HasColumnName("idAppointment");
            this.Property(t => t.employee_cin).HasColumnName("employee_cin");
            this.Property(t => t.insured_cin).HasColumnName("insured_cin");
            this.Property(t => t.employee_id).HasColumnName("employee_id");
            this.Property(t => t.insured_id).HasColumnName("insured_id");
        }
    }
}
