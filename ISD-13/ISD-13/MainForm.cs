using ISD_13.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_13
{
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler LoadAllTables;
        public event EventHandler SaveInfo;
        public event EventHandler SelectedPlayer;
        public event EventHandler SelectedCombat;       
        public MainPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);           
        }
        public object PlayerBindingSource
        {            
            set { playerBindingSource.DataSource = value; }
        }
        public object CombatBindingSource
        {
            set { combatBindingSource.DataSource = value; }
        }
        public object TransactionBindingSource
        {
            set { transactionBindingSource.DataSource = value; }
        }
        public object HitLogBindingSource
        {
            set { hitLogBindingSource.DataSource = value; }
        }
        public string CurrentCombat
        {
            get { return CurrentCombatIdTxt.Text; }
            set { CurrentCombatIdTxt.Text = value; }
        }
        public int CurrentCombatId
        {
            get { return (int)CombatDGV[0, CombatDGV.CurrentCellAddress.Y].Value; }
        }
        public string CurrentPlayerName
        {
            get { return CurrentPlayerTxt.Text; }
            set { CurrentPlayerTxt.Text = value; }
        }
        public int CurrentPlayerId
        {
            get { return (int)PlayerDGV[0, PlayerDGV.CurrentCellAddress.Y].Value; }            
        }
        public int CurrentTabIndex
        {
            get { return MainTab.SelectedIndex; }
        }        
        public bool ValidEmailCBStatus
        {
            get { return ValidEmailCB.Checked; }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            PlayerDGV.DataSource = playerBindingSource;
            CombatDGV.DataSource = combatBindingSource;
            TransactionDGV.DataSource = transactionBindingSource;
            HitDGV.DataSource = hitLogBindingSource;
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }            
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveInfo != null) { SaveInfo(this, EventArgs.Empty); }            
        }

        private void ValidEmailCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void PlayerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedPlayer != null) { SelectedPlayer(this, EventArgs.Empty); }           
        }
           
        private void CombatDGV_Click(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void MainTab_Click(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void CombatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedCombat != null) { SelectedCombat(this, EventArgs.Empty); }
        }

        private void TransactionDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void HitDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
