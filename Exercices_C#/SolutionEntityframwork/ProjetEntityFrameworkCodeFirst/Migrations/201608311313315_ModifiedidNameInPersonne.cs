namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedidNameInPersonne : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personnes", "adresse_idAdresse", "dbo.Adresses");
            DropIndex("dbo.Personnes", new[] { "adresse_idAdresse" });
            RenameColumn(table: "dbo.Personnes", name: "adresse_idAdresse", newName: "idAdresse");
            AlterColumn("dbo.Personnes", "idAdresse", c => c.Int(nullable: false));
            CreateIndex("dbo.Personnes", "idAdresse");
            AddForeignKey("dbo.Personnes", "idAdresse", "dbo.Adresses", "idAdresse", cascadeDelete: true);
            DropColumn("dbo.Personnes", "AdresseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnes", "AdresseId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Personnes", "idAdresse", "dbo.Adresses");
            DropIndex("dbo.Personnes", new[] { "idAdresse" });
            AlterColumn("dbo.Personnes", "idAdresse", c => c.Int());
            RenameColumn(table: "dbo.Personnes", name: "idAdresse", newName: "adresse_idAdresse");
            CreateIndex("dbo.Personnes", "adresse_idAdresse");
            AddForeignKey("dbo.Personnes", "adresse_idAdresse", "dbo.Adresses", "idAdresse");
        }
    }
}
