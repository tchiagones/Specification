namespace DP.Core.Integration.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bases",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Service_UniqueId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("productionControl.Service", t => t.Service_UniqueId)
                .Index(t => t.Service_UniqueId);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Base_UniqueId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bases", t => t.Base_UniqueId)
                .Index(t => t.Base_UniqueId);
            
            CreateTable(
                "dbo.Criteria",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Client_UniqueId = c.Int(),
                        Field_UniqueId = c.Guid(),
                        Service_UniqueId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_SIS_CLIENTE", t => t.Client_UniqueId)
                .ForeignKey("dbo.Fields", t => t.Field_UniqueId)
                .ForeignKey("productionControl.Service", t => t.Service_UniqueId)
                .Index(t => t.Client_UniqueId)
                .Index(t => t.Field_UniqueId)
                .Index(t => t.Service_UniqueId);
            
            CreateTable(
                "dbo.ValueCriterions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CriterionUniqueId = c.Guid(nullable: false),
                        FieldUniqueId = c.Guid(nullable: false),
                        BDValue = c.String(),
                        Specification_UniqueId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.CriterionUniqueId, cascadeDelete: true)
                .ForeignKey("dbo.DPSpecifications", t => t.Specification_UniqueId)
                .Index(t => t.CriterionUniqueId)
                .Index(t => t.Specification_UniqueId);
            
            CreateTable(
                "dbo.DPSpecifications",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        OperatorLogical = c.Int(nullable: false),
                        OperatorArithmetic = c.Int(nullable: false),
                        SpecificationType = c.Int(nullable: false),
                        Criterion_UniqueId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.Criterion_UniqueId)
                .Index(t => t.Criterion_UniqueId);
            
            CreateTable(
                "dbo.Expressions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        OperatorLogical = c.Int(nullable: false),
                        OperatorArithmetic = c.Int(nullable: false),
                        Specification_UniqueId = c.Guid(),
                        ValueCriterion_UniqueId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DPSpecifications", t => t.Specification_UniqueId)
                .ForeignKey("dbo.ValueCriterions", t => t.ValueCriterion_UniqueId)
                .Index(t => t.Specification_UniqueId)
                .Index(t => t.ValueCriterion_UniqueId);
            
            CreateTable(
                "dbo.T_SIS_CLIENTE",
                c => new
                    {
                        clienteId = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                    })
                .PrimaryKey(t => t.clienteId);
            
            CreateTable(
                "productionControl.Service",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "productionControl.ServiceCommunication",
                c => new
                    {
                        ServiceId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceId, t.ClientId })
                .ForeignKey("productionControl.Service", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.T_SIS_CLIENTE", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bases", "Service_UniqueId", "productionControl.Service");
            DropForeignKey("dbo.Criteria", "Service_UniqueId", "productionControl.Service");
            DropForeignKey("dbo.Criteria", "Field_UniqueId", "dbo.Fields");
            DropForeignKey("dbo.Criteria", "Client_UniqueId", "dbo.T_SIS_CLIENTE");
            DropForeignKey("productionControl.ServiceCommunication", "ClientId", "dbo.T_SIS_CLIENTE");
            DropForeignKey("productionControl.ServiceCommunication", "ServiceId", "productionControl.Service");
            DropForeignKey("dbo.ValueCriterions", "Specification_UniqueId", "dbo.DPSpecifications");
            DropForeignKey("dbo.Expressions", "ValueCriterion_UniqueId", "dbo.ValueCriterions");
            DropForeignKey("dbo.Expressions", "Specification_UniqueId", "dbo.DPSpecifications");
            DropForeignKey("dbo.DPSpecifications", "Criterion_UniqueId", "dbo.Criteria");
            DropForeignKey("dbo.ValueCriterions", "CriterionUniqueId", "dbo.Criteria");
            DropForeignKey("dbo.Fields", "Base_UniqueId", "dbo.Bases");
            DropIndex("productionControl.ServiceCommunication", new[] { "ClientId" });
            DropIndex("productionControl.ServiceCommunication", new[] { "ServiceId" });
            DropIndex("dbo.Expressions", new[] { "ValueCriterion_UniqueId" });
            DropIndex("dbo.Expressions", new[] { "Specification_UniqueId" });
            DropIndex("dbo.DPSpecifications", new[] { "Criterion_UniqueId" });
            DropIndex("dbo.ValueCriterions", new[] { "Specification_UniqueId" });
            DropIndex("dbo.ValueCriterions", new[] { "CriterionUniqueId" });
            DropIndex("dbo.Criteria", new[] { "Service_UniqueId" });
            DropIndex("dbo.Criteria", new[] { "Field_UniqueId" });
            DropIndex("dbo.Criteria", new[] { "Client_UniqueId" });
            DropIndex("dbo.Fields", new[] { "Base_UniqueId" });
            DropIndex("dbo.Bases", new[] { "Service_UniqueId" });
            DropTable("productionControl.ServiceCommunication");
            DropTable("productionControl.Service");
            DropTable("dbo.T_SIS_CLIENTE");
            DropTable("dbo.Expressions");
            DropTable("dbo.DPSpecifications");
            DropTable("dbo.ValueCriterions");
            DropTable("dbo.Criteria");
            DropTable("dbo.Fields");
            DropTable("dbo.Bases");
        }
    }
}
