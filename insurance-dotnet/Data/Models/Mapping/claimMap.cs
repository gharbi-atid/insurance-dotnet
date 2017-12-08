using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Models.Mapping
{
    public class claimMap : EntityTypeConfiguration<claim>
    {
        public claimMap()
        {
            // Primary Key
            this.HasKey(t => t.idClaim);

            // Properties
            this.Property(t => t.idClaim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.damagePostion)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.place)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.image)
                .HasMaxLength(255);

            this.Property(t => t.lat)
                .HasMaxLength(255);

            this.Property(t => t.lng)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("claim", "insurancedb");
            this.Property(t => t.idClaim).HasColumnName("idClaim");
            this.Property(t => t.Injury).HasColumnName("Injury");
            this.Property(t => t.damagePostion).HasColumnName("damagePostion");
            this.Property(t => t.damageToOtherProperty).HasColumnName("damageToOtherProperty");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.nbCar).HasColumnName("nbCar");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.place).HasColumnName("place");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.contract_refContract).HasColumnName("contract_refContract");
            this.Property(t => t.employee_id).HasColumnName("employee_id");
            this.Property(t => t.estimation_id).HasColumnName("estimation_id");
            this.Property(t => t.Circumstances).HasColumnName("Circumstances");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.lat).HasColumnName("lat");
            this.Property(t => t.lng).HasColumnName("lng");
        }
    }
}
