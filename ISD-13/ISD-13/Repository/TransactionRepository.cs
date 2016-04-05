using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(Context db)
            : base(db)
        {
        }
       
        public IEnumerable<Transaction> FindAllTransactionByUserId(int id)
        {
            var query = db.Transactions.Where(t => t.Player.Id == id).ToList();
            return query;
        }
        public void SaveEdit(List<Transaction> transactionList)
        {
            foreach (Transaction p in transactionList)
            {
                if (GetAll().Any(x => x.Id == p.Id))
                {
                    Update(p);

                }
                else
                {
                    Create(p);
                }
            }
            Delete(transactionList);
        }

        public void Delete(List<Transaction> transactionList)
        {
            var query = GetAll().Except(transactionList);
            foreach (var p in query)
            {
                Delete(p.Id);
            }
        }
    }
}
