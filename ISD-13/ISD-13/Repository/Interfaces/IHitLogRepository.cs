using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface IHitLogRepository : IRepository<HitLog>
    {
        List<HitLog> FindHitLogsByUserId(int id);
        void SaveEdit(List<HitLog> hitLogList, bool deleteMod);
    }   
}
