using MyLibraryApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User FindUserByEmail(string email);
    }    
}
