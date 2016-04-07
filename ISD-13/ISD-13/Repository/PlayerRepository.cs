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
       
        public IEnumerable<Player> FindUsersByValidEmail()
        {
            var query = GetAll().Where(p => p.EMailValid == true).ToList();
            return query;
        }       

        public void SaveEdit(List<Player> playerList, bool deleteMod)
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
            if (deleteMod)
            {
                Delete(playerList);
            }
            else
            {
                DeleteWhithEmailValidation(playerList); 
            }            
        }

        public void Delete(List<Player> playerList)
        {
            var query = GetAll().Except(playerList);
            foreach (var p in query)
            {
                Delete(p.Id);
            }
        }

        public void DeleteWhithEmailValidation(List<Player> playerList)
        {
            foreach (Player p in playerList)
            {
                var query = GetAll().Where(x => x.EMailValid == true).Except(playerList);
                foreach (var d in query)
                {
                    Delete(d.Id);
                }
            }
        }
    }
}
