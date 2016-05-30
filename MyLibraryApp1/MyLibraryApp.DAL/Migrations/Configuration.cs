namespace MyLibraryApp.DAL.Migrations
{
    using MyLibraryApp.DAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DropCreateDatabaseAlways<MyLibraryApp.DAL.EF.LibraryContext>
    {    
        protected override void Seed(MyLibraryApp.DAL.EF.LibraryContext context)
        {
            if (context.Books.Count() == 0)
            {
                var user1 = new User() { Name = "Mark", Email = "mark@ukr.net" };
                var user2 = new User() { Name = "Tom", Email = "tom@ukr.net" };
                var user3 = new User() { Name = "Jim", Email = "jim@ukr.net" };
                var user4 = new User() { Name = "Peter", Email = "peter@ukr.net" };
                var user5 = new User() { Name = "Jek", Email = "jek@ukr.net" };
                var user6 = new User() { Name = "Mishell", Email = "mishell@ukr.net" };
                var user7 = new User() { Name = "Patrik", Email = "patrik@ukr.net" };
                var user8 = new User() { Name = "Elizabet", Email = "elizabet@ukr.net" };
                context.Users.AddRange(new List<User> { user1, user2, user3, user4, user5, user6, user7, user8 });
                context.SaveChanges();

                var author1 = new Author() { Name = "J.R.R.Tolkien" };
                var author2 = new Author() { Name = "Arlene Eisenberg" };
                var author3 = new Author() { Name = "Heidi Murkoff" };
                var author4 = new Author() { Name = "Jack Canfield" };
                var author5 = new Author() { Name = "Mark Victor Hansen" };
                var author6 = new Author() { Name = "Dan Brown " };
                var author7 = new Author() { Name = "J. K. Rowling" };
                var author8 = new Author() { Name = "Eric Carle" };
                var author9 = new Author() { Name = "Frank Herbert " };
                context.Authors.AddRange(new List<Author> { author1, author2, author3, author4, author5, author6, author7, author8, author9 });
                context.SaveChanges();

                var book1 = new Book() { Name = "The Lord of the Rings", FirstAuthor = author1, Status = true };
                var book2 = new Book() { Name = "What to Expect When You're Expecting", FirstAuthor = author2, SecondAuthor = author3, Status = true };
                var book3 = new Book() { Name = "Chicken Soup for the Soul", FirstAuthor = author4, SecondAuthor = author5, Status = true };
                var book4 = new Book() { Name = "The Da Vinci Code", FirstAuthor = author6, Status = true };
                var book5 = new Book() { Name = "Harry Potter and the Chamber of Secrets", FirstAuthor = author7, Status = true };
                var book6 = new Book() { Name = "Angels & Demons", FirstAuthor = author6, Status = true };
                var book7 = new Book() { Name = "The Lost Symbol", FirstAuthor = author6, Status = true };
                var book8 = new Book() { Name = "The Very Hungry Caterpillar", FirstAuthor = author8, Status = true };
                var book9 = new Book() { Name = "Dune", FirstAuthor = author9, Status = true };
                context.Books.AddRange(new List<Book> { book1, book2, book3, book4, book5, book6, book7, book8, book9 });
                context.SaveChanges();
            }
        }
    }
}
