namespace ISD_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ProfileCombats", name: "ProfileId", newName: "Profile_Id");
            RenameColumn(table: "dbo.ProfileCombats", name: "CombatsId", newName: "Combat_Id");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_ProfileId", newName: "IX_Profile_Id");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_CombatsId", newName: "IX_Combat_Id");
            AddColumn("dbo.Combats", "FirstPlayer_Id", c => c.Int());
            AddColumn("dbo.Combats", "SecondPlayer_Id", c => c.Int());
            AddColumn("dbo.Combats", "Winner_Id", c => c.Int());
            CreateIndex("dbo.Combats", "FirstPlayer_Id");
            CreateIndex("dbo.Combats", "SecondPlayer_Id");
            CreateIndex("dbo.Combats", "Winner_Id");
            AddForeignKey("dbo.Combats", "FirstPlayer_Id", "dbo.Players", "Id");
            AddForeignKey("dbo.Combats", "SecondPlayer_Id", "dbo.Players", "Id");
            AddForeignKey("dbo.Combats", "Winner_Id", "dbo.Players", "Id");
            DropColumn("dbo.Combats", "FirstPlayer");
            DropColumn("dbo.Combats", "SecondPlayer");
            DropColumn("dbo.Combats", "Winner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Combats", "Winner", c => c.String());
            AddColumn("dbo.Combats", "SecondPlayer", c => c.String());
            AddColumn("dbo.Combats", "FirstPlayer", c => c.String());
            DropForeignKey("dbo.Combats", "Winner_Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "SecondPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "FirstPlayer_Id", "dbo.Players");
            DropIndex("dbo.Combats", new[] { "Winner_Id" });
            DropIndex("dbo.Combats", new[] { "SecondPlayer_Id" });
            DropIndex("dbo.Combats", new[] { "FirstPlayer_Id" });
            DropColumn("dbo.Combats", "Winner_Id");
            DropColumn("dbo.Combats", "SecondPlayer_Id");
            DropColumn("dbo.Combats", "FirstPlayer_Id");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_Combat_Id", newName: "IX_CombatsId");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_Profile_Id", newName: "IX_ProfileId");
            RenameColumn(table: "dbo.ProfileCombats", name: "Combat_Id", newName: "CombatsId");
            RenameColumn(table: "dbo.ProfileCombats", name: "Profile_Id", newName: "ProfileId");
        }
    }
}
