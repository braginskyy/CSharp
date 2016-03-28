using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISD_13.Repository.Interfaces;
using ISD_13.Data;
using System.Data.Entity;

namespace ISD_13.Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(Context db)
            : base(db)
        {
        }
        public IEnumerable<Player> FindRegisteredUsersByDate(DateTime date)
        {
            var query = GetAll().Where(p => p.Profile.Date < date).ToList(); 
            return query;
        }

        public IEnumerable<Player> FindUsersByValidEmail()
        {
            var query = GetAll().Where(p => p.EMailValid == true).ToList();
            return query;
        }
    }
}
