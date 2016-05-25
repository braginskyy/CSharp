using MyLibraryApp.DAL.Entities;
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
            Database.SetInitializer<LibraryContext>(new MigrateDatabaseToLatestVersion<LibraryContext, Migrations.Configuration>());
        }       
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
