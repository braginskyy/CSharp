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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(LibraryContext db)
            : base(db)
        {
        }
        public User FindUserByEmail(string email)
        {
            var query = GetAll().Where(p => p.Email == email).FirstOrDefault();
            return query;
        }
    }
}
