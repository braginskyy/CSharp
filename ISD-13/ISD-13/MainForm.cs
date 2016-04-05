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
        public event EventHandler FindPlayerInfo;
        public MainPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
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
        public object PlayerTable
        {
            set { PlayerDGV.DataSource = value; }
        }
        public object TransactionTable
        {
            set { TransactionDGV.DataSource = value; }
        }
        public object CombatTable
        {
            set { CombatDGV.DataSource = value; }
        }
        public object HitLogTable
        {
            set { HitDGV.DataSource = value; }
        }
        public bool ValidEmailCBStatus
        {
            get { return ValidEmailCB.Checked; }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
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
            if (FindPlayerInfo != null) { FindPlayerInfo(this, EventArgs.Empty); }           
        }
    }
}
