namespace ISD_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ProfileCombats", name: "Profile_Id", newName: "ProfileId");
            RenameColumn(table: "dbo.ProfileCombats", name: "Combat_Id", newName: "CombatsId");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_Profile_Id", newName: "IX_ProfileId");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_Combat_Id", newName: "IX_CombatsId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_CombatsId", newName: "IX_Combat_Id");
            RenameIndex(table: "dbo.ProfileCombats", name: "IX_ProfileId", newName: "IX_Profile_Id");
            RenameColumn(table: "dbo.ProfileCombats", name: "CombatsId", newName: "Combat_Id");
            RenameColumn(table: "dbo.ProfileCombats", name: "ProfileId", newName: "Profile_Id");
        }
    }
}
