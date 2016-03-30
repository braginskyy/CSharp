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
        public IEnumerable<Combat> FindCombatsByUserId(int id)
        {
            var query = db.Combats.Where(c => (c.FirstPlayer.Id == id) || (c.SecondPlayer.Id == id)).ToList();           
            return query; 
        }
    }
}
