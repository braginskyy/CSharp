using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Interfaces
{
    public interface IMainForm
    {
        event EventHandler LoadAllTables;       
        event EventHandler SaveInfo;
        event EventHandler FindPlayerInfo;
        string CurrentPlayerName { get;  set; }
        int CurrentPlayerId { get; }
        int CurrentTabIndex { get; }
        object PlayerTable { set; }
        object TransactionTable { set; }
        object CombatTable { set; }
        object HitLogTable { set; }
        bool ValidEmailCBStatus { get; }        
    }
}
