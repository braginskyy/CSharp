using ISD_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Repository.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {        
        IEnumerable<Player> FindUsersByValidEmail();
        void SaveEdit(List<Player> playerList, bool deleteMod);
    }
}
