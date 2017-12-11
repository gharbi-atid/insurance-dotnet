using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.USER_TYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Adresse)
                .HasMaxLength(255);

            this.Property(t => t.FirstName)
                .HasMaxLength(255);

            this.Property(t => t.confrimPassword)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.photo)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            this.Property(t => t.sex)
                .HasMaxLength(255);

            this.Property(t => t.Diplome)
                .HasMaxLength(255);

            this.Property(t => t.statut)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "dbo");
            this.Property(t => t.USER_TYPE).HasColumnName("USER_TYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Adresse).HasColumnName("Adresse");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.birthDate).HasColumnName("birthDate");
            this.Property(t => t.confrimPassword).HasColumnName("confrimPassword");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.dateOfContract).HasColumnName("dateOfContract");
            this.Property(t => t.dateOfHire).HasColumnName("dateOfHire");
            this.Property(t => t.Diplome).HasColumnName("Diplome");
            this.Property(t => t.statut).HasColumnName("statut");
        }
    }
}
