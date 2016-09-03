namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FormationPersonnes", newName: "FormationPersonne1");
            CreateTable(
                "dbo.FormationPersonnes",
                c => new
                    {
                        idFormation = c.Int(nullable: false),
                        idPersonne = c.Int(nullable: false),
                        Something = c.Int(nullable: false),
                        SomeThingElse = c.String(),
                    })
                .PrimaryKey(t => new { t.idFormation, t.idPersonne })
                .ForeignKey("dbo.Formations", t => t.idFormation, cascadeDelete: true)
                .ForeignKey("dbo.Personnes", t => t.idPersonne, cascadeDelete: true)
                .Index(t => t.idFormation)
                .Index(t => t.idPersonne);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormationPersonnes", "idPersonne", "dbo.Personnes");
            DropForeignKey("dbo.FormationPersonnes", "idFormation", "dbo.Formations");
            DropIndex("dbo.FormationPersonnes", new[] { "idPersonne" });
            DropIndex("dbo.FormationPersonnes", new[] { "idFormation" });
            DropTable("dbo.FormationPersonnes");
            RenameTable(name: "dbo.FormationPersonne1", newName: "FormationPersonnes");
        }
    }
}
