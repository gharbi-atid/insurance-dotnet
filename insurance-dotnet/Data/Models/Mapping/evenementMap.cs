using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class evenementMap : EntityTypeConfiguration<evenement>
    {
        public evenementMap()
        {
            // Primary Key
            this.HasKey(t => t.EventID);

            // Properties
            this.Property(t => t.EventID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("evenement", "insurancedb");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.DateDebut).HasColumnName("DateDebut");
            this.Property(t => t.DateFin).HasColumnName("DateFin");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.available).HasColumnName("available");
            this.Property(t => t.booked).HasColumnName("booked");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.price).HasColumnName("price");
        }
    }
}
