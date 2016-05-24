using MyLibraryApp.DAL.EF;
using MyLibraryApp.DAL.Repository.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository
{
    public class Proxy : IProxy
    {
        private readonly LibraryContext db;
        private IAuthorRepository authorRepository;
        private IBookRepository bookRepository;
        private IHistoryRepository historyRepository;
        private IUserRepository userRepository;
        public Proxy()
        {
            this.db = new LibraryContext();
        }
        public IAuthorRepository Author
        {
            get
            {
                if (authorRepository == null)
                {
                    authorRepository = new AuthorRepository(db);
                }
                return authorRepository;
            }
        }

        public IBookRepository Book
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new BookRepository(db);
                }
                return bookRepository;
            }
        }

        public IHistoryRepository History
        {
            get
            {
                if (historyRepository == null)
                {
                    historyRepository = new HistoryRepository(db);
                }
                return historyRepository;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
