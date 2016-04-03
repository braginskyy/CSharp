using ISD_13.Data;
using ISD_13.Interfaces;
using ISD_13.Repository;
using ISD_13.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_13
{
    public class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IUnitOfWork unitOfWork;  
        private List<Player> playerList;
        private BindingSource playerBindingSource = new BindingSource();        
        public MainPresenter(MainForm view)
        {
            this.view = view;
            this.unitOfWork = new UnitOfWork(new Context());
            view.LoadPlayerTables += view_LoadTable;
           
            view.SavePlayer += view_SavePlayer;
        }

        void view_SavePlayer(object sender, EventArgs e)
        {            
            
            unitOfWork.Player.SaveEdit(playerList);
            unitOfWork.Save();
        }

        //void view_UpdateTransactionTable(object sender, EventArgs e)
        //{
        //    var transaction = unitOfWork.Transaction.Get(view.EditCell);
        //    transaction.Sum = (int)view.TransactionTable;
        //    unitOfWork.Transaction.Update();
        //}

        //void view_LoadHit(object sender, EventArgs e)
        //{
        //    view.HitTable = unitOfWork.HitLog.FindHitsByUserId(view.CurrentCombatId) ;           
        //}

        //void view_LoadCombat(object sender, EventArgs e)
        //{
        //    view.CombatTable = unitOfWork.Combat.FindCombatsByUserId(view.CurrentUserId);
        //}

        //void view_LoadTransaction(object sender, EventArgs e)
        //{
        //    view.TransactionTable = unitOfWork.Transaction.FindAllTransactionByUserId(view.CurrentUserId);
        //}
        void view_LoadTable(object sender, EventArgs e)
        {            
            playerList = unitOfWork.Player.GetAll().ToList();
            if (view.ValidEmailCBStatus) { playerList = unitOfWork.Player.FindUsersByValidEmail().ToList(); }
            //if (view.TopTenUsersBySumCBStatus) { playerList = unitOfWork.Player.TopTenUsersBySum().ToList(); }
            playerBindingSource.DataSource = playerList;
            view.PlayerTable = playerBindingSource;
        }
    }
}
