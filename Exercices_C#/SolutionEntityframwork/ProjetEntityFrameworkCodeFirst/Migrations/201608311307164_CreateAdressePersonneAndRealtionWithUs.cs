namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAdressePersonneAndRealtionWithUs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        idAdresse = c.Int(nullable: false, identity: true),
                        NomRue = c.String(nullable: false),
                        CodePostale = c.String(nullable: false),
                        Ville = c.String(nullable: false),
                        Pays = c.String(nullable: false),
                        PersonneId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idAdresse);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        idPersonne = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 8000, unicode: false),
                        AdresseId = c.Int(nullable: false),
                        adresse_idAdresse = c.Int(),
                    })
                .PrimaryKey(t => t.idPersonne)
                .ForeignKey("dbo.Adresses", t => t.adresse_idAdresse)
                .Index(t => t.Email, unique: true)
                .Index(t => t.adresse_idAdresse);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnes", "adresse_idAdresse", "dbo.Adresses");
            DropIndex("dbo.Personnes", new[] { "adresse_idAdresse" });
            DropIndex("dbo.Personnes", new[] { "Email" });
            DropTable("dbo.Personnes");
            DropTable("dbo.Adresses");
        }
    }
}
