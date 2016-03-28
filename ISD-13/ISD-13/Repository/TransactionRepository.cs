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
        public IEnumerable TopTenUsersBySum()
        {
            var query = db.Transactions.Join(db.Players, t => t.Player.Id, p => p.Id, (t, p) => new
                {
                    Login = p.Login,
                    Password = p.Password,
                    Email = p.EMail,
                    EMailValid = p.EMailValid,
                    Profile = p.Profile,
                    Id = p.Id,
                    Sum = t.Sum

                }).OrderByDescending(t => t.Sum).Take(10).ToList();
            return query;
        }
        public IEnumerable<Transaction> FindAllTransactionByUserId(int id)
        {
            var query = db.Transactions.Where(t => t.Player.Id == id).ToList();
            return query;
        }
    }
}
