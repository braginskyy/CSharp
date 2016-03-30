namespace ISD_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Combats", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Combats", new[] { "Profile_Id" });
            CreateTable(
                "dbo.ProfileCombats",
                c => new
                    {
                        Profile_Id = c.Int(nullable: false),
                        Combat_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Profile_Id, t.Combat_Id })
                .ForeignKey("dbo.Profiles", t => t.Profile_Id, cascadeDelete: true)
                .ForeignKey("dbo.Combats", t => t.Combat_Id, cascadeDelete: true)
                .Index(t => t.Profile_Id)
                .Index(t => t.Combat_Id);
            
            DropColumn("dbo.Combats", "Profile_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Combats", "Profile_Id", c => c.Int());
            DropForeignKey("dbo.ProfileCombats", "Combat_Id", "dbo.Combats");
            DropForeignKey("dbo.ProfileCombats", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.ProfileCombats", new[] { "Combat_Id" });
            DropIndex("dbo.ProfileCombats", new[] { "Profile_Id" });
            DropTable("dbo.ProfileCombats");
            CreateIndex("dbo.Combats", "Profile_Id");
            AddForeignKey("dbo.Combats", "Profile_Id", "dbo.Profiles", "Id");
        }
    }
}
