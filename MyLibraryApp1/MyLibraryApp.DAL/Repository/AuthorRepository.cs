using MyLibraryApp.DAL.EF;
using MyLibraryApp.DAL.Entities;
using MyLibraryApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryContext db)
            : base(db)
        {
        }
        public Author FindAuthorByName(string name)
        {
            var author = GetAll().Where(p => p.Name == name).FirstOrDefault();
            return author;
        }       
    }
}
