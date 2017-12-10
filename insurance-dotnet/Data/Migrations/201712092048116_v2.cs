namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interviews", "etat", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Interviews", "etat");
        }
    }
}
