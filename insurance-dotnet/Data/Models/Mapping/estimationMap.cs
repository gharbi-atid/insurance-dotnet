using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class estimationMap : EntityTypeConfiguration<estimation>
    {
        public estimationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.result)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("estimation", "insurancedb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Painting).HasColumnName("Painting");
            this.Property(t => t.SheetMetalWorkshop).HasColumnName("SheetMetalWorkshop");
            this.Property(t => t.Woodwork).HasColumnName("Woodwork");
            this.Property(t => t.electricity).HasColumnName("electricity");
            this.Property(t => t.mechanical).HasColumnName("mechanical");
            this.Property(t => t.priceWorkForce).HasColumnName("priceWorkForce");
            this.Property(t => t.result).HasColumnName("result");
            this.Property(t => t.tapestry).HasColumnName("tapestry");
            this.Property(t => t.valueAfter).HasColumnName("valueAfter");
            this.Property(t => t.valueBefore).HasColumnName("valueBefore");
            this.Property(t => t.valueClam).HasColumnName("valueClam");
        }
    }
}
