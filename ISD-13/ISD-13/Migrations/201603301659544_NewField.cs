namespace ISD_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewField : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Combats", "Winner_Id", "dbo.Players");
            DropIndex("dbo.Combats", new[] { "Winner_Id" });
            RenameColumn(table: "dbo.Combats", name: "FirstPlayer_Id", newName: "FirstPlayerNav_Id");
            RenameColumn(table: "dbo.Combats", name: "SecondPlayer_Id", newName: "SecondPlayerNav_Id");
            RenameIndex(table: "dbo.Combats", name: "IX_FirstPlayer_Id", newName: "IX_FirstPlayerNav_Id");
            RenameIndex(table: "dbo.Combats", name: "IX_SecondPlayer_Id", newName: "IX_SecondPlayerNav_Id");
            AddColumn("dbo.Combats", "FirstPlayer", c => c.String());
            AddColumn("dbo.Combats", "SecondPlayer", c => c.String());
            AddColumn("dbo.Combats", "Winner", c => c.String());
            DropColumn("dbo.Combats", "Winner_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Combats", "Winner_Id", c => c.Int());
            DropColumn("dbo.Combats", "Winner");
            DropColumn("dbo.Combats", "SecondPlayer");
            DropColumn("dbo.Combats", "FirstPlayer");
            RenameIndex(table: "dbo.Combats", name: "IX_SecondPlayerNav_Id", newName: "IX_SecondPlayer_Id");
            RenameIndex(table: "dbo.Combats", name: "IX_FirstPlayerNav_Id", newName: "IX_FirstPlayer_Id");
            RenameColumn(table: "dbo.Combats", name: "SecondPlayerNav_Id", newName: "SecondPlayer_Id");
            RenameColumn(table: "dbo.Combats", name: "FirstPlayerNav_Id", newName: "FirstPlayer_Id");
            CreateIndex("dbo.Combats", "Winner_Id");
            AddForeignKey("dbo.Combats", "Winner_Id", "dbo.Players", "Id");
        }
    }
}
