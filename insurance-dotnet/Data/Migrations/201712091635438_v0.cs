namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "insurancedb.actuality",
                c => new
                    {
                        idActuality = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idActuality);
            
            CreateTable(
                "insurancedb.actualitycomment",
                c => new
                    {
                        idActualityComment = c.Int(nullable: false),
                        actuality_idActuality = c.Int(),
                        insured_cin = c.Int(),
                        insured_id = c.Int(),
                    })
                .PrimaryKey(t => t.idActualityComment);
            
            CreateTable(
                "insurancedb.appointment",
                c => new
                    {
                        idAppointment = c.Int(nullable: false),
                        employee_cin = c.Int(),
                        insured_cin = c.Int(),
                        employee_id = c.Int(),
                        insured_id = c.Int(),
                    })
                .PrimaryKey(t => t.idAppointment);
            
            CreateTable(
                "insurancedb.att",
                c => new
                    {
                        idMatricule = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idMatricule);
            
            CreateTable(
                "insurancedb.car",
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
                "insurancedb.claimpicture",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        url = c.Binary(),
                        claim_idClaim = c.Int(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "insurancedb.claim",
                c => new
                    {
                        idClaim = c.Int(nullable: false),
                        Injury = c.Boolean(nullable: false),
                        damagePostion = c.String(maxLength: 255, storeType: "nvarchar"),
                        damageToOtherProperty = c.Boolean(nullable: false),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        nbCar = c.Int(nullable: false),
                        picture = c.Binary(),
                        place = c.String(maxLength: 255, storeType: "nvarchar"),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        contract_refContract = c.Int(),
                        employee_id = c.Int(),
                        estimation_id = c.Int(),
                        Circumstances = c.Binary(),
                        image = c.String(maxLength: 255, storeType: "nvarchar"),
                        lat = c.String(maxLength: 255, storeType: "nvarchar"),
                        lng = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idClaim);
            
            CreateTable(
                "insurancedb.contract_claim",
                c => new
                    {
                        Contract_refContract = c.Int(nullable: false),
                        listClaims_idClaim = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contract_refContract, t.listClaims_idClaim });
            
            CreateTable(
                "insurancedb.contract_prepossessing",
                c => new
                    {
                        Contract_refContract = c.Int(nullable: false),
                        listPrepossessings_idPrepossessing = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contract_refContract, t.listPrepossessings_idPrepossessing });
            
            CreateTable(
                "insurancedb.contract",
                c => new
                    {
                        refContract = c.Int(nullable: false),
                        insured_cin = c.Int(),
                        log_idLog = c.Int(),
                        creationdate = c.DateTime(precision: 0),
                        police = c.Int(nullable: false),
                        car_idCar = c.Int(),
                        insured_id = c.Int(),
                    })
                .PrimaryKey(t => t.refContract);
            
            CreateTable(
                "insurancedb.estimation",
                c => new
                    {
                        id = c.Int(nullable: false),
                        Painting = c.Single(nullable: false),
                        SheetMetalWorkshop = c.Single(nullable: false),
                        Woodwork = c.Single(nullable: false),
                        electricity = c.Single(nullable: false),
                        mechanical = c.Single(nullable: false),
                        priceWorkForce = c.Single(nullable: false),
                        result = c.String(maxLength: 255, storeType: "nvarchar"),
                        tapestry = c.Single(nullable: false),
                        valueAfter = c.Single(nullable: false),
                        valueBefore = c.Single(nullable: false),
                        valueClam = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "insurancedb.evenement_user",
                c => new
                    {
                        listEvents_EventID = c.Int(nullable: false),
                        participants_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.listEvents_EventID, t.participants_id });
            
            CreateTable(
                "insurancedb.evenement",
                c => new
                    {
                        EventID = c.Int(nullable: false),
                        DateDebut = c.DateTime(precision: 0),
                        DateFin = c.DateTime(precision: 0),
                        address = c.String(maxLength: 255, storeType: "nvarchar"),
                        available = c.Int(nullable: false),
                        booked = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "insurancedb.forumcomment",
                c => new
                    {
                        id = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        topic_id = c.Int(),
                        user_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "insurancedb.forumtopic",
                c => new
                    {
                        id = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        image = c.String(maxLength: 255, storeType: "nvarchar"),
                        nbVue = c.Int(nullable: false),
                        title = c.String(maxLength: 255, storeType: "nvarchar"),
                        user = c.Binary(),
                    })
                .PrimaryKey(t => t.id);
            
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
                .ForeignKey("insurancedb.user", t => t.idstagiaire_id)
                .Index(t => t.idstagiaire_id);
            
            CreateTable(
                "insurancedb.user",
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
                "insurancedb.log",
                c => new
                    {
                        idLog = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idLog);
            
            CreateTable(
                "insurancedb.police",
                c => new
                    {
                        idPolice = c.Int(nullable: false),
                        contract_refContract = c.Int(),
                        classe = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idPolice);
            
            CreateTable(
                "insurancedb.prepossessing",
                c => new
                    {
                        idPrepossessing = c.Int(nullable: false),
                        contract_refContract = c.Int(),
                    })
                .PrimaryKey(t => t.idPrepossessing);
            
            CreateTable(
                "insurancedb.reclamation",
                c => new
                    {
                        idReclamation = c.Int(nullable: false),
                        insured_cin = c.Int(),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        subject = c.String(maxLength: 255, storeType: "nvarchar"),
                        insured_id = c.Int(),
                        dateTime = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.idReclamation);
            
            CreateTable(
                "insurancedb.reunion_user",
                c => new
                    {
                        Reunion_idReunion = c.Int(nullable: false),
                        listInvitedEmployees_cin = c.Int(nullable: false),
                        listReunions_idReunion = c.Int(nullable: false),
                        listInvitedEmployees_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reunion_idReunion, t.listInvitedEmployees_cin, t.listReunions_idReunion, t.listInvitedEmployees_id });
            
            CreateTable(
                "insurancedb.reunion",
                c => new
                    {
                        idReunion = c.Int(nullable: false),
                        date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        name = c.String(maxLength: 255, storeType: "nvarchar"),
                        employee_cin = c.Int(),
                        mailTo = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idReunion);
            
            CreateTable(
                "insurancedb.survey",
                c => new
                    {
                        idSurvey = c.Int(nullable: false),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        endDate = c.DateTime(precision: 0),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idSurvey);
            
            CreateTable(
                "insurancedb.surveyvote",
                c => new
                    {
                        idSurveyVote = c.Int(nullable: false),
                        insured_cin = c.Int(),
                        survey_idSurvey = c.Int(),
                        insured_id = c.Int(),
                        vote = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idSurveyVote);
            
            CreateTable(
                "insurancedb.testimony",
                c => new
                    {
                        idTestimony = c.Int(nullable: false),
                        Email = c.String(maxLength: 255, storeType: "nvarchar"),
                        firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                        lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                        phoneNumber = c.Int(nullable: false),
                        claim_idClaim = c.Int(),
                    })
                .PrimaryKey(t => t.idTestimony);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interviews", "idstagiaire_id", "insurancedb.user");
            DropIndex("dbo.Interviews", new[] { "idstagiaire_id" });
            DropTable("insurancedb.testimony");
            DropTable("insurancedb.surveyvote");
            DropTable("insurancedb.survey");
            DropTable("insurancedb.reunion");
            DropTable("insurancedb.reunion_user");
            DropTable("insurancedb.reclamation");
            DropTable("insurancedb.prepossessing");
            DropTable("insurancedb.police");
            DropTable("insurancedb.log");
            DropTable("insurancedb.user");
            DropTable("dbo.Interviews");
            DropTable("insurancedb.forumtopic");
            DropTable("insurancedb.forumcomment");
            DropTable("insurancedb.evenement");
            DropTable("insurancedb.evenement_user");
            DropTable("insurancedb.estimation");
            DropTable("insurancedb.contract");
            DropTable("insurancedb.contract_prepossessing");
            DropTable("insurancedb.contract_claim");
            DropTable("insurancedb.claim");
            DropTable("insurancedb.claimpicture");
            DropTable("insurancedb.car");
            DropTable("insurancedb.att");
            DropTable("insurancedb.appointment");
            DropTable("insurancedb.actualitycomment");
            DropTable("insurancedb.actuality");
        }
    }
}
