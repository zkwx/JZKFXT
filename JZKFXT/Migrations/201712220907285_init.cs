namespace JZKFXT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExamID = c.Int(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        QuestionNo = c.String(),
                        OptionIDs = c.String(),
                        DisabledInfoID = c.Int(nullable: false),
                        Other = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DisabledInfo", t => t.DisabledInfoID, cascadeDelete: true)
                .Index(t => t.DisabledInfoID);
            
            CreateTable(
                "dbo.AssistiveDevice",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParentAssistiveDeviceID = c.Int(nullable: false),
                        Name = c.String(),
                        Type = c.String(),
                        Option_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Option", t => t.Option_ID)
                .Index(t => t.Option_ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Degree",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DisabilityReason",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DisabledInfo_Detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        DegreeID = c.Int(nullable: false),
                        RehabilitationID = c.Int(),
                        NextID = c.Int(),
                        TargetExamName = c.String(),
                        DisabledInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Degree", t => t.DegreeID, cascadeDelete: true)
                .ForeignKey("dbo.DisabledInfo", t => t.DisabledInfoID, cascadeDelete: true)
                .ForeignKey("dbo.Next", t => t.NextID)
                .ForeignKey("dbo.Rehabilitation", t => t.RehabilitationID)
                .Index(t => t.CategoryID)
                .Index(t => t.DegreeID)
                .Index(t => t.RehabilitationID)
                .Index(t => t.NextID)
                .Index(t => t.DisabledInfoID);
            
            CreateTable(
                "dbo.DisabledInfo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sex = c.Int(),
                        Tel = c.String(),
                        Guardian = c.String(),
                        RelationshipID = c.Int(),
                        HasCertificate = c.Boolean(nullable: false),
                        Certificate = c.String(),
                        IDNumber = c.String(),
                        Need = c.Boolean(nullable: false),
                        Nation = c.String(),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        TargetExamName = c.String(),
                        UserSignUrl = c.String(),
                        PatientSignUrl = c.String(),
                        UpdateTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                        CategoryID = c.Int(),
                        DegreeID = c.Int(),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.CategoryID)
                .ForeignKey("dbo.Degree", t => t.DegreeID)
                .ForeignKey("dbo.Relationship", t => t.RelationshipID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.RelationshipID)
                .Index(t => t.CategoryID)
                .Index(t => t.DegreeID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.ExamRecord",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExamID = c.Int(),
                        DisabledInfoID = c.Int(nullable: false),
                        Done = c.Boolean(nullable: false),
                        Evaluated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DisabledInfo", t => t.DisabledInfoID, cascadeDelete: true)
                .ForeignKey("dbo.Exam", t => t.ExamID)
                .Index(t => t.ExamID)
                .Index(t => t.DisabledInfoID);
            
            CreateTable(
                "dbo.Exam",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExamID = c.Int(nullable: false),
                        QuestionNo = c.String(),
                        QuestionText = c.String(),
                        IsFirst = c.Boolean(nullable: false),
                        Multiple = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exam", t => t.ExamID, cascadeDelete: true)
                .Index(t => t.ExamID);
            
            CreateTable(
                "dbo.Option",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExamID = c.Int(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        OptionText = c.String(),
                        ContentText = c.String(),
                        NextQuestionNo = c.String(),
                        NextQuestionID = c.Int(),
                        Score = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Question", t => t.QuestionID, cascadeDelete: true)
                .Index(t => t.QuestionID);
            
            CreateTable(
                "dbo.Relationship",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        RealName = c.String(),
                        RoleID = c.Int(nullable: false),
                        CreateTime = c.DateTime(),
                        LastLoginTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Role", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        RoleName = c.String(),
                        Description = c.String(),
                        Duty = c.String(),
                        MenuIDs = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Next",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rehabilitation",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Category = c.String(),
                        CategoryDetail = c.String(),
                        RehabilitationName = c.String(),
                        FuJu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DisabledInfo_Detail", "RehabilitationID", "dbo.Rehabilitation");
            DropForeignKey("dbo.DisabledInfo_Detail", "NextID", "dbo.Next");
            DropForeignKey("dbo.DisabledInfo", "UserID", "dbo.User");
            DropForeignKey("dbo.User", "RoleID", "dbo.Role");
            DropForeignKey("dbo.DisabledInfo", "RelationshipID", "dbo.Relationship");
            DropForeignKey("dbo.ExamRecord", "ExamID", "dbo.Exam");
            DropForeignKey("dbo.Option", "QuestionID", "dbo.Question");
            DropForeignKey("dbo.AssistiveDevice", "Option_ID", "dbo.Option");
            DropForeignKey("dbo.Question", "ExamID", "dbo.Exam");
            DropForeignKey("dbo.ExamRecord", "DisabledInfoID", "dbo.DisabledInfo");
            DropForeignKey("dbo.DisabledInfo_Detail", "DisabledInfoID", "dbo.DisabledInfo");
            DropForeignKey("dbo.DisabledInfo", "DegreeID", "dbo.Degree");
            DropForeignKey("dbo.DisabledInfo", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.Answer", "DisabledInfoID", "dbo.DisabledInfo");
            DropForeignKey("dbo.DisabledInfo_Detail", "DegreeID", "dbo.Degree");
            DropForeignKey("dbo.DisabledInfo_Detail", "CategoryID", "dbo.Category");
            DropIndex("dbo.User", new[] { "RoleID" });
            DropIndex("dbo.Option", new[] { "QuestionID" });
            DropIndex("dbo.Question", new[] { "ExamID" });
            DropIndex("dbo.ExamRecord", new[] { "DisabledInfoID" });
            DropIndex("dbo.ExamRecord", new[] { "ExamID" });
            DropIndex("dbo.DisabledInfo", new[] { "UserID" });
            DropIndex("dbo.DisabledInfo", new[] { "DegreeID" });
            DropIndex("dbo.DisabledInfo", new[] { "CategoryID" });
            DropIndex("dbo.DisabledInfo", new[] { "RelationshipID" });
            DropIndex("dbo.DisabledInfo_Detail", new[] { "DisabledInfoID" });
            DropIndex("dbo.DisabledInfo_Detail", new[] { "NextID" });
            DropIndex("dbo.DisabledInfo_Detail", new[] { "RehabilitationID" });
            DropIndex("dbo.DisabledInfo_Detail", new[] { "DegreeID" });
            DropIndex("dbo.DisabledInfo_Detail", new[] { "CategoryID" });
            DropIndex("dbo.AssistiveDevice", new[] { "Option_ID" });
            DropIndex("dbo.Answer", new[] { "DisabledInfoID" });
            DropTable("dbo.Rehabilitation");
            DropTable("dbo.Next");
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.Relationship");
            DropTable("dbo.Option");
            DropTable("dbo.Question");
            DropTable("dbo.Exam");
            DropTable("dbo.ExamRecord");
            DropTable("dbo.DisabledInfo");
            DropTable("dbo.DisabledInfo_Detail");
            DropTable("dbo.DisabilityReason");
            DropTable("dbo.Degree");
            DropTable("dbo.Category");
            DropTable("dbo.AssistiveDevice");
            DropTable("dbo.Answer");
        }
    }
}
