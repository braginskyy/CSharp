using MyLibraryApp.DAL.Entities;
using MyLibraryApp.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.EF
{
    public class LibraryContext : DbContext
    {        
        public LibraryContext()
            : base("DBConnection")
        {
            Database.SetInitializer<LibraryContext>(new Configuration());            
        }       
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
