namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreationFormationAndrelationWithPersonne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Formations",
                c => new
                    {
                        idFormation = c.Int(nullable: false, identity: true),
                        NomFormation = c.String(nullable: false),
                        NbEntreprise = c.Int(nullable: false),
                        NomEntreprise = c.String(),
                        TypeFormation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idFormation);
            
            CreateTable(
                "dbo.FormationPersonnes",
                c => new
                    {
                        Formation_idFormation = c.Int(nullable: false),
                        Personne_idPersonne = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Formation_idFormation, t.Personne_idPersonne })
                .ForeignKey("dbo.Formations", t => t.Formation_idFormation, cascadeDelete: true)
                .ForeignKey("dbo.Personnes", t => t.Personne_idPersonne, cascadeDelete: true)
                .Index(t => t.Formation_idFormation)
                .Index(t => t.Personne_idPersonne);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormationPersonnes", "Personne_idPersonne", "dbo.Personnes");
            DropForeignKey("dbo.FormationPersonnes", "Formation_idFormation", "dbo.Formations");
            DropIndex("dbo.FormationPersonnes", new[] { "Personne_idPersonne" });
            DropIndex("dbo.FormationPersonnes", new[] { "Formation_idFormation" });
            DropTable("dbo.FormationPersonnes");
            DropTable("dbo.Formations");
        }
    }
}
