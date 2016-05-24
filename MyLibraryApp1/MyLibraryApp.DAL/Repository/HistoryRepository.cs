
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
    public class HistoryRepository : Repository<History>, IHistoryRepository
    {
        public HistoryRepository(LibraryContext db)
            : base(db)
        {
        }
        public History FindLastHistoryByBook(Book book)
        {
            var query = GetAll().Where(p => p.Book == book).LastOrDefault();
            return query;
        }
    }
}
