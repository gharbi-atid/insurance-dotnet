namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateInterview = c.DateTime(nullable: false, precision: 0),
                        idstagiaire_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("insurancedb.user", t => t.idstagiaire_id)
                .Index(t => t.idstagiaire_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interviews", "idstagiaire_id", "insurancedb.user");
            DropIndex("dbo.Interviews", new[] { "idstagiaire_id" });
            DropTable("dbo.Interviews");
        }
    }
}
