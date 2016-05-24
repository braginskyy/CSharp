using MyLibraryApp.DAL.Entities;
using MyLibraryApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository.Interfaces
{
    public interface IHistoryRepository : IRepository<History>
    {
        History FindLastHistoryByBook(Book book);
    }
}
