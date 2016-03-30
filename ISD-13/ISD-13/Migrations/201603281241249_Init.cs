namespace ISD_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Combats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CombatTypePVP = c.Boolean(nullable: false),
                        FirstPlayer = c.String(),
                        SecondPlayer = c.String(),
                        Winner = c.String(),
                        Experience = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Profile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Profile_Id);
            
            CreateTable(
                "dbo.HitLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HitValue = c.Int(nullable: false),
                        Part = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Combat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Combats", t => t.Combat_Id)
                .Index(t => t.Combat_Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        EMail = c.String(),
                        EMailValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sum = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Player_Id = c.Int(),
                        Profile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.Profile_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.Transactions", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Profiles", "Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "Profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.HitLogs", "Combat_Id", "dbo.Combats");
            DropIndex("dbo.Transactions", new[] { "Profile_Id" });
            DropIndex("dbo.Transactions", new[] { "Player_Id" });
            DropIndex("dbo.Profiles", new[] { "Id" });
            DropIndex("dbo.HitLogs", new[] { "Combat_Id" });
            DropIndex("dbo.Combats", new[] { "Profile_Id" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Players");
            DropTable("dbo.Profiles");
            DropTable("dbo.HitLogs");
            DropTable("dbo.Combats");
        }
    }
}
