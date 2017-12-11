namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rendezvous",
                c => new
                    {
                        RendezVousId = c.Int(nullable: false, identity: true),
                        DateRendezVous = c.DateTime(nullable: false, precision: 0),
                        Description = c.String(unicode: false),
                        NomAssurance = c.String(unicode: false),
                        Insured_cin = c.Binary(),
                        oks = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.RendezVousId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rendezvous");
        }
    }
}
