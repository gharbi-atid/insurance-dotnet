using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class reunionMap : EntityTypeConfiguration<reunion>
    {
        public reunionMap()
        {
            // Primary Key
            this.HasKey(t => t.idReunion);

            // Properties
            this.Property(t => t.idReunion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.mailTo)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reunion", "insurancedb");
            this.Property(t => t.idReunion).HasColumnName("idReunion");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.employee_cin).HasColumnName("employee_cin");
            this.Property(t => t.mailTo).HasColumnName("mailTo");
        }
    }
}
