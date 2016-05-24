namespace MyLibraryApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            AddColumn("dbo.Authors", "Book_Id", c => c.Int());
            AddColumn("dbo.Books", "FirstAuthor_Id", c => c.Int());
            AddColumn("dbo.Books", "SecondAuthor_Id", c => c.Int());
            AddColumn("dbo.Books", "Author_Id", c => c.Int());
            CreateIndex("dbo.Authors", "Book_Id");
            CreateIndex("dbo.Books", "FirstAuthor_Id");
            CreateIndex("dbo.Books", "SecondAuthor_Id");
            CreateIndex("dbo.Books", "Author_Id");
            AddForeignKey("dbo.Authors", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.Books", "FirstAuthor_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.Books", "SecondAuthor_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.Books", "Author_Id", "dbo.Authors", "Id");
            DropTable("dbo.BookAuthors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id });
            
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Books", "SecondAuthor_Id", "dbo.Authors");
            DropForeignKey("dbo.Books", "FirstAuthor_Id", "dbo.Authors");
            DropForeignKey("dbo.Authors", "Book_Id", "dbo.Books");
            DropIndex("dbo.Books", new[] { "Author_Id" });
            DropIndex("dbo.Books", new[] { "SecondAuthor_Id" });
            DropIndex("dbo.Books", new[] { "FirstAuthor_Id" });
            DropIndex("dbo.Authors", new[] { "Book_Id" });
            DropColumn("dbo.Books", "Author_Id");
            DropColumn("dbo.Books", "SecondAuthor_Id");
            DropColumn("dbo.Books", "FirstAuthor_Id");
            DropColumn("dbo.Authors", "Book_Id");
            CreateIndex("dbo.BookAuthors", "Author_Id");
            CreateIndex("dbo.BookAuthors", "Book_Id");
            AddForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
