using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class forumtopicMap : EntityTypeConfiguration<forumtopic>
    {
        public forumtopicMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.image)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("forumtopic", "insurancedb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.nbVue).HasColumnName("nbVue");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.user).HasColumnName("user");
        }
    }
}
