namespace ISD_13.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Date", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Players", "DateCreate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "DateCreate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Players", "Date");
        }
    }
}
