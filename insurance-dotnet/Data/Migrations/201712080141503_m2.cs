namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interviews", "experience", c => c.String(unicode: false));
            AddColumn("dbo.Interviews", "diplome", c => c.String(unicode: false));
            AddColumn("dbo.Interviews", "motivations", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Interviews", "motivations");
            DropColumn("dbo.Interviews", "diplome");
            DropColumn("dbo.Interviews", "experience");
        }
    }
}
