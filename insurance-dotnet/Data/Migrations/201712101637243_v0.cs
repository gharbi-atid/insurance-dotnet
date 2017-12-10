namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            DropColumn("insurancedb.actuality", "DateDebut");
        }
        
        public override void Down()
        {
            AddColumn("insurancedb.actuality", "DateDebut", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
