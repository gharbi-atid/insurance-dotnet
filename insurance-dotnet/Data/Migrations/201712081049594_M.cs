namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M : DbMigration
    {
        public override void Up()
        {
            AddColumn("insurancedb.evenement", "places", c => c.Int(nullable: false));
            AddColumn("insurancedb.evenement", "ImageName", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("insurancedb.evenement", "ImageName");
            DropColumn("insurancedb.evenement", "places");
        }
    }
}
