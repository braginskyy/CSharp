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
        public List<HitLog> FindHitLogsByUserId(int id)
        {
            var query = db.HitLogs.Where(h => h.Combat.Id == id).ToList();
            return query;
        }
        public void SaveEdit(List<HitLog> hitLogList, bool deleteMod)
        {
            foreach (HitLog h in hitLogList)
            {
                if (GetAll().Any(x => x.Id == h.Id))
                {
                    Update(h);

                }
                else
                {
                    Create(h);
                }
            }
            if (deleteMod)
            {
                Delete(hitLogList);
            }
            else
            {
                DeleteWhithSelectedCombat(hitLogList);
            }
            
        }

        public void Delete(List<HitLog> hitLogList)
        {
            var query = GetAll().Except(hitLogList);
            foreach (var h in query)
            {
                Delete(h.Id);
            }
        }
        public void DeleteWhithSelectedCombat(List<HitLog> hitLogList)
        {
            foreach (HitLog h in hitLogList)
            {
                var query = GetAll()
                    .Where(x => x.Combat == h.Combat )
                    .Except(hitLogList);
                foreach (var d in query)
                {
                    Delete(d.Id);
                }
            }
        }
    }
}
