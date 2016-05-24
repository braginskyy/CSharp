using MyLibraryApp.DAL.Entities;
using MyLibraryApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> FindAvailableBook();
        Book FindBookByName(string name);
        IEnumerable<Book> FindBooksByAuthor(string name);       
    }
}
