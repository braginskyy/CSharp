using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Interfaces
{
    public interface IMainForm
    {
        event EventHandler LoadPlayerTables;
        event EventHandler SavePlayer;
        object PlayerTable { set; }
        bool ValidEmailCBStatus { get; }
        bool TopTenUsersBySumCBStatus { get; }
    }
}
