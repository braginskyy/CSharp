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
    public class HitLogRepository : Repository<HitLog>, IHitLogRepository
    {
        public HitLogRepository(Context db)
            : base(db)
        {
        }
        public IEnumerable<HitLog> FindHitsByUserId(int id)
        {
            var query = db.HitLogs.Where(h => h.Combat.Id == id).ToList();
            return query;
        }
        public void SaveEdit(List<HitLog> hitLogList)
        {
            foreach (HitLog p in hitLogList)
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
            Delete(hitLogList);
        }

        public void Delete(List<HitLog> hitLogList)
        {
            var query = GetAll().Except(hitLogList);
            foreach (var p in query)
            {
                Delete(p.Id);
            }
        }
    }
}
