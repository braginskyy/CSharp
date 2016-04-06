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
        event EventHandler SelectedPlayer;
        event EventHandler SelectedCombat;
        object PlayerBindingSource { set; }
        object CombatBindingSource { set; }
        object TransactionBindingSource { set; }
        object HitLogBindingSource { set; }
        string CurrentCombat { get; set; }
        int CurrentCombatId { get; }
        string CurrentPlayerName { get; set; }
        int CurrentPlayerId { get; }
        int CurrentTabIndex { get; }       
        bool ValidEmailCBStatus { get; }        
    }
}
