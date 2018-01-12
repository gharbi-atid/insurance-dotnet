using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models.Mapping
{
    public class carMap : EntityTypeConfiguration<car>
    {
        public carMap()
        {
            // Primary Key
            this.HasKey(t => t.idCar);

            // Properties
            this.Property(t => t.idCar)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.marque)
                .HasMaxLength(255);

            this.Property(t => t.matricule)
                .HasMaxLength(255);

            this.Property(t => t.modele)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("car", "insurancedb");
            this.Property(t => t.idCar).HasColumnName("idCar");
            this.Property(t => t.contract_refContract).HasColumnName("contract_refContract");
            this.Property(t => t.marque).HasColumnName("marque");
            this.Property(t => t.matricule).HasColumnName("matricule");
            this.Property(t => t.modele).HasColumnName("modele");
        }
    }
}
