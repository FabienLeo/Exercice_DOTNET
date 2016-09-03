namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreationVoitureAndRelationWithPersonne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Voitures",
                c => new
                    {
                        idVoiture = c.Int(nullable: false, identity: true),
                        Couleur = c.String(nullable: false),
                        NbPorte = c.Int(nullable: false),
                        idPersonne = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idVoiture)
                .ForeignKey("dbo.Personnes", t => t.idPersonne, cascadeDelete: true)
                .Index(t => t.idPersonne);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Voitures", "idPersonne", "dbo.Personnes");
            DropIndex("dbo.Voitures", new[] { "idPersonne" });
            DropTable("dbo.Voitures");
        }
    }
}
