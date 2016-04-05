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
        private List<Transaction> transactionList;
        private List<Combat> combatList;
        private List<HitLog> hitLogList;
        private BindingSource playerBindingSource = new BindingSource();
        private BindingSource transactionBindingSource = new BindingSource();
        private BindingSource combatBindingSource = new BindingSource();
        private BindingSource hitLogBindingSource = new BindingSource();
        public MainPresenter(IMainForm view)
        {
            this.view = view;
            this.unitOfWork = new UnitOfWork();
            view.LoadAllTables += view_LoadAllTables;
            view.SaveInfo += SaveInfo;
            view.FindPlayerInfo += view_FindPlayerInfo;
        }

        void view_FindPlayerInfo(object sender, EventArgs e)
        {
            view.CurrentPlayerName = unitOfWork.Player.Get(view.CurrentPlayerId).Login;
        }

        void SaveInfo(object sender, EventArgs e)
        {
            switch (view.CurrentTabIndex)
            {
                case 0:
                    {
                        unitOfWork.Player.SaveEdit(playerList);
                        unitOfWork.Save();
                        LoadPlayerTable();
                        break;
                    }
                case 1:
                    {
                        unitOfWork.Transaction.SaveEdit(transactionList);
                        unitOfWork.Save();
                        LoadTransactionTable();
                        break;
                    }
                case 2:
                    {
                        unitOfWork.Combat.SaveEdit(combatList);
                        unitOfWork.Save();
                        LoadCombatTable();
                        break;
                    }
                case 3:
                    {
                        unitOfWork.HitLog.SaveEdit(hitLogList);
                        unitOfWork.Save();
                        LoadHitLogTable();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void view_LoadAllTables(object sender, EventArgs e)
        {
            LoadPlayerTable();
            LoadTransactionTable();
            LoadCombatTable();
            LoadHitLogTable();
        }
        public void LoadTransactionTable()
        {
            transactionList = unitOfWork.Transaction.GetAll().ToList();
            transactionBindingSource.DataSource = transactionList;
            view.TransactionTable = transactionBindingSource;
        }
        public void LoadCombatTable()
        {
            if (view.CurrentPlayerName == "")
            {
                combatList = unitOfWork.Combat.GetAll().ToList();                
            }
            else
            {
                combatList = unitOfWork.Combat.FindCombatsByUserId(view.CurrentPlayerId); 
            }
            combatBindingSource.DataSource = combatList;
            view.CombatTable = combatBindingSource;
           
        }
        public void LoadHitLogTable()
        {
            hitLogList = unitOfWork.HitLog.GetAll().ToList();
            hitLogBindingSource.DataSource = hitLogList;
            view.HitLogTable = hitLogBindingSource;
        }
        public void LoadPlayerTable()
        {
            playerList = unitOfWork.Player.GetAll().ToList();
            if (view.ValidEmailCBStatus) 
            { 
                playerList = unitOfWork.Player.FindUsersByValidEmail().ToList(); 
            }           
            playerBindingSource.DataSource = playerList;
            view.PlayerTable = playerBindingSource;
        }
    }
}
