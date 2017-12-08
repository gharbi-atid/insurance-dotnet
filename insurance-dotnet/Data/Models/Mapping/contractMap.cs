using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class contractMap : EntityTypeConfiguration<contract>
    {
        public contractMap()
        {
            // Primary Key
            this.HasKey(t => t.refContract);

            // Properties
            this.Property(t => t.refContract)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("contract", "insurancedb");
            this.Property(t => t.refContract).HasColumnName("refContract");
            this.Property(t => t.insured_cin).HasColumnName("insured_cin");
            this.Property(t => t.log_idLog).HasColumnName("log_idLog");
            this.Property(t => t.creationdate).HasColumnName("creationdate");
            this.Property(t => t.police).HasColumnName("police");
            this.Property(t => t.car_idCar).HasColumnName("car_idCar");
            this.Property(t => t.insured_id).HasColumnName("insured_id");
        }
    }
}
