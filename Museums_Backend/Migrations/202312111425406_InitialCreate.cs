namespace Museums_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Öffnungszeiten",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Wochentag = c.DateTime(nullable: false),
                        Öffnungszeit = c.DateTime(nullable: false),
                        Schließungszeit = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BesucherAnzahlAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Anzahl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BesucherAnzahlBs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Anzahl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BesucherAnzahlBs");
            DropTable("dbo.BesucherAnzahlAs");
            DropTable("dbo.Öffnungszeiten");
        }
    }
}
