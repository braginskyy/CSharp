
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository.Interfaces
{
    public interface IProxy
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IHistoryRepository History { get; }
        IUserRepository User { get; }        
        void Save();
    }
}
