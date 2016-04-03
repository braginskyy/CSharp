using ISD_13.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface ITransactionRepository : IRepository<Transaction>
    { 
        IEnumerable<Transaction> FindAllTransactionByUserId(int id);
    }
}
