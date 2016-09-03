namespace ProjetEntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePersonneIdInAdresse : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Adresses", "PersonneId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Adresses", "PersonneId", c => c.Int(nullable: false));
        }
    }
}
