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
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryContext db)
            : base(db)
        {
        }
        public IEnumerable<Book> FindAvailableBook()
        {
            var query = GetAll().Where(p => p.Status == true).ToList();
            return query;
        }
        public Book FindBookByName(string name)
        {
            var query = GetAll().Where(p => p.Name == name).FirstOrDefault();
            return query;
        }
        public IEnumerable<Book> FindBooksByAuthor(string name)
        {
            var query = GetAll().Where(p => p.FirstAuthor.Name == name)
                .Union(GetAll().Where(p => p.SecondAuthor !=null).Where(p => p.SecondAuthor.Name == name)).ToList();  
            return query;
        }
    }
}
