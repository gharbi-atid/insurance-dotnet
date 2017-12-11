namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.car",
                c => new
                    {
                        idCar = c.Int(nullable: false),
                        contract_refContract = c.Int(),
                        marque = c.String(maxLength: 255, storeType: "nvarchar"),
                        matricule = c.String(maxLength: 255, storeType: "nvarchar"),
                        modele = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idCar);
            
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateInterview = c.DateTime(nullable: false, precision: 0),
                        experience = c.String(unicode: false),
                        diplome = c.String(unicode: false),
                        motivations = c.String(unicode: false),
                        idstagiaire_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.user", t => t.idstagiaire_id)
                .Index(t => t.idstagiaire_id);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        id = c.Int(nullable: false),
                        USER_TYPE = c.String(nullable: false, maxLength: 31, storeType: "nvarchar"),
                        Adresse = c.String(maxLength: 255, storeType: "nvarchar"),
                        FirstName = c.String(maxLength: 255, storeType: "nvarchar"),
                        Tel = c.Int(nullable: false),
                        birthDate = c.DateTime(precision: 0),
                        confrimPassword = c.String(maxLength: 255, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        mail = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        photo = c.String(maxLength: 255, storeType: "nvarchar"),
                        role = c.String(maxLength: 255, storeType: "nvarchar"),
                        sex = c.String(maxLength: 255, storeType: "nvarchar"),
                        dateOfContract = c.DateTime(precision: 0),
                        dateOfHire = c.DateTime(precision: 0),
                        Diplome = c.String(maxLength: 255, storeType: "nvarchar"),
                        statut = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
                        
            CreateTable(
                "dbo.Tugs",
                c => new
                    {
                        idTug = c.Int(nullable: false, identity: true),
                        reference = c.String(unicode: false),
                        zone = c.String(unicode: false),
                        startDate = c.DateTime(nullable: false, precision: 0),
                        endDate = c.DateTime(nullable: false, precision: 0),
                        type = c.String(unicode: false),
                        status = c.String(unicode: false),
                        price = c.Int(nullable: false),
                        idCar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idTug)
                .ForeignKey("dbo.car", t => t.idCar, cascadeDelete: true)
                .Index(t => t.idCar);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tugs", "idCar", "dbo.car");
            DropForeignKey("dbo.Interviews", "idstagiaire_id", "dbo.user");
            DropIndex("dbo.Tugs", new[] { "idCar" });
            DropIndex("dbo.Interviews", new[] { "idstagiaire_id" });
            DropTable("dbo.Tugs");
            DropTable("dbo.user");
            DropTable("dbo.Interviews");
            DropTable("dbo.car");
        }
    }
}
