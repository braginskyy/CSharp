using ISD_13.Data;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository
{
    public class CombatRepository : Repository<Combat>, ICombatRepository
    {
        public CombatRepository(Context db)
            : base(db)
        {
        }
        public List<Combat> FindCombatsByUserId(int id)
        {
            var query = db.Combats.Where(c => (c.FirstPlayer.Id == id) || (c.SecondPlayer.Id == id)).ToList();           
            return query; 
        }
        public void SaveEdit(List<Combat> combatList)
        {
            foreach (Combat p in combatList)
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
            Delete(combatList);
        }

        public void Delete(List<Combat> combatList)
        {
            var query = GetAll().Except(combatList);
            foreach (var p in query)
            {
                Delete(p.Id);
            }
        }
    }
}
