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
            var query = GetAll().Where(p => p.Date< date).ToList(); 
            return query;
        }

        public IEnumerable<Player> FindUsersByValidEmail()
        {
            var query = GetAll().Where(p => p.EMailValid == true).ToList();
            return query;
        }
        public void SaveUpdates(List<Player> playerList)
        {
            foreach (Player p in playerList)
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
            var query = GetAll().Except(playerList);
            foreach (var p in query)
            {
                Delate(p.Id);
            }            
        }
    }
}
