namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.actuality", "titre", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.actuality", "description", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.actuality", "Date", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.actuality", "Date");
            DropColumn("dbo.actuality", "description");
            DropColumn("dbo.actuality", "titre");
        }
    }
}
