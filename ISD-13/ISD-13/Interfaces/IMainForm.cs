using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Interfaces
{
    public interface IMainForm
    {
        event EventHandler LoadTable;
        event EventHandler TopTenUsersBySum;
        event EventHandler ValidEMail;
        event EventHandler LoadTransaction;
        event EventHandler LoadCombat;
        event EventHandler LoadHit;
        event EventHandler UpdateTransactionTable;
        event EventHandler SavePlayer;
        int CurrentUserId { get; }
        int CurrentCombatId { get; }
        int EditCell { get; }
        object MainTable { set; }
        object TransactionTable { get; set; }
        object CombatTable { set; }
        object HitTable { set; }
    }
}
