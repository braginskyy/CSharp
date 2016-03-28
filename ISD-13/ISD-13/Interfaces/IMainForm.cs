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
        int CurrentUserId { get; }
        object MainTable { set; }
        object TransactionTable { set; }
    }
}
