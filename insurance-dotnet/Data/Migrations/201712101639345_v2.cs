namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("insurancedb.actuality", "Date", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("insurancedb.actuality", "Date");
        }
    }
}
