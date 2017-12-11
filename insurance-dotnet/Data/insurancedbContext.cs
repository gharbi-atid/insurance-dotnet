using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;

using Data.Models;
using Domain;
using Data.Conventionn;

namespace Data
{
    public partial class insurancedbContext : DbContext
    {
        public insurancedbContext()
            : base("Name=insurancedbContext")
        {
        }

        public DbSet<actuality> actualities { get; set; }
        public DbSet<actualitycomment> actualitycomments { get; set; }
        public DbSet<appointment> appointments { get; set; }
        public DbSet<att> atts { get; set; }
        public DbSet<car> cars { get; set; }
        public DbSet<claim> claims { get; set; }
        public DbSet<claimpicture> claimpictures { get; set; }
        public DbSet<contract> contracts { get; set; }
        public DbSet<contract_claim> contract_claim { get; set; }
        public DbSet<contract_prepossessing> contract_prepossessing { get; set; }
        public DbSet<estimation> estimations { get; set; }
        public DbSet<evenement> evenements { get; set; }
        public DbSet<evenement_user> evenement_user { get; set; }
        public DbSet<forumcomment> forumcomments { get; set; }
        public DbSet<forumtopic> forumtopics { get; set; }
        public DbSet<log> logs { get; set; }
        public DbSet<police> police { get; set; }
        public DbSet<prepossessing> prepossessings { get; set; }
        public DbSet<reclamation> reclamations { get; set; }
        public DbSet<reunion> reunions { get; set; }
        public DbSet<reunion_user> reunion_user { get; set; }
        public DbSet<survey> surveys { get; set; }
        public DbSet<surveyvote> surveyvotes { get; set; }
        public DbSet<testimony> testimonies { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<Tug> tugs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new actualityMap());
            modelBuilder.Configurations.Add(new actualitycommentMap());
            modelBuilder.Configurations.Add(new appointmentMap());
            modelBuilder.Configurations.Add(new attMap());
            modelBuilder.Configurations.Add(new carMap());
            modelBuilder.Configurations.Add(new claimMap());
            modelBuilder.Configurations.Add(new claimpictureMap());
            modelBuilder.Configurations.Add(new contractMap());
            modelBuilder.Configurations.Add(new contract_claimMap());
            modelBuilder.Configurations.Add(new contract_prepossessingMap());
            modelBuilder.Configurations.Add(new estimationMap());
            modelBuilder.Configurations.Add(new evenementMap());
            modelBuilder.Configurations.Add(new evenement_userMap());
            modelBuilder.Configurations.Add(new forumcommentMap());
            modelBuilder.Configurations.Add(new forumtopicMap());
            modelBuilder.Configurations.Add(new logMap());
            modelBuilder.Configurations.Add(new policeMap());
            modelBuilder.Configurations.Add(new prepossessingMap());
            modelBuilder.Configurations.Add(new reclamationMap());
            modelBuilder.Configurations.Add(new reunionMap());
            modelBuilder.Configurations.Add(new reunion_userMap());
            modelBuilder.Configurations.Add(new surveyMap());
            modelBuilder.Configurations.Add(new surveyvoteMap());
            modelBuilder.Configurations.Add(new testimonyMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
