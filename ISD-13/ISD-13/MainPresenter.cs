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
        private readonly IProxy proxy;
        private List<Player> playerList;
        private List<Transaction> transactionList;
        private List<Combat> combatList;
        private List<HitLog> hitLogList;        
        public MainPresenter(IMainForm view)
        {
            this.view = view;
            this.proxy = new Proxy();
            view.LoadAllTables += view_LoadAllTables;
            view.SaveInfo += SaveInfo;
            view.SelectedPlayer += view_SelectedPlayer;
            view.SelectedCombat += view_SelectedCombat;
        }

        void view_SelectedCombat(object sender, EventArgs e)
        {
            if (proxy.Combat.Get(view.CurrentCombatId) != null)
            {
                view.CurrentCombat = proxy.Combat.Get(view.CurrentCombatId).Id.ToString();
            }
            else
            {
                view.CurrentCombat = "";
            }
        }

        void view_SelectedPlayer(object sender, EventArgs e)
        {
            view.CurrentCombat = "";
            if (proxy.Player.Get(view.CurrentPlayerId) != null)
            {
                view.CurrentPlayerName = proxy.Player.Get(view.CurrentPlayerId).Login;
            }
            else
            {
                view.CurrentPlayerName = "";
            }
        }

        void SaveInfo(object sender, EventArgs e)
        {
            switch (view.CurrentTabIndex)
            {
                case 0:
                    {
                        proxy.Player.SaveEdit(playerList);
                        proxy.Save();
                        LoadPlayerTable();
                        break;
                    }
                case 1:
                    {
                        proxy.Transaction.SaveEdit(transactionList);
                        proxy.Save();
                        LoadTransactionTable();
                        break;
                    }
                case 2:
                    {
                        proxy.Combat.SaveEdit(combatList);
                        proxy.Save();
                        LoadCombatTable();
                        break;
                    }
                case 3:
                    {
                        proxy.HitLog.SaveEdit(hitLogList);
                        proxy.Save();
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
            transactionList = proxy.Transaction.GetAll().ToList();
            if (view.CurrentPlayerName != "")
            {
                transactionList = proxy.Transaction.FindTransactionsByUserId(view.CurrentPlayerId);
            }
            view.TransactionBindingSource = transactionList;
        }
        public void LoadCombatTable()
        {
            combatList = proxy.Combat.GetAll().ToList();
            if (view.CurrentPlayerName != "")
            {
                combatList = proxy.Combat.FindCombatsByUserId(view.CurrentPlayerId);
            }
            view.CombatBindingSource = combatList;

        }
        public void LoadHitLogTable()
        {
            hitLogList = proxy.HitLog.GetAll().ToList();
            view.HitLogBindingSource = hitLogList;
        }
        public void LoadPlayerTable()
        {
            playerList = proxy.Player.GetAll().ToList();
            if (view.ValidEmailCBStatus)
            {
                playerList = proxy.Player.FindUsersByValidEmail().ToList();
            }           
            view.PlayerBindingSource = playerList;
        }
    }
}
