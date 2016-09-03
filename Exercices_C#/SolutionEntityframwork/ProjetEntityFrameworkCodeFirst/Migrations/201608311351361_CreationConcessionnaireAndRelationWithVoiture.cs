namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreationConcessionnaireAndRelationWithVoiture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Concessionnaires",
                c => new
                    {
                        idConcessionnaire = c.Int(nullable: false, identity: true),
                        NomConcessionnaire = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idConcessionnaire);
            
            AddColumn("dbo.Voitures", "idConcessionnaire", c => c.Int(nullable: false));
            CreateIndex("dbo.Voitures", "idConcessionnaire");
            AddForeignKey("dbo.Voitures", "idConcessionnaire", "dbo.Concessionnaires", "idConcessionnaire", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Voitures", "idConcessionnaire", "dbo.Concessionnaires");
            DropIndex("dbo.Voitures", new[] { "idConcessionnaire" });
            DropColumn("dbo.Voitures", "idConcessionnaire");
            DropTable("dbo.Concessionnaires");
        }
    }
}
