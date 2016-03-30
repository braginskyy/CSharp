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
    public partial class MainForm : Form , IMainForm
    {
        public event EventHandler LoadTable;
        public event EventHandler TopTenUsersBySum;
        public event EventHandler ValidEMail;
        public event EventHandler LoadTransaction;
        public event EventHandler LoadCombat;
        public event EventHandler LoadHit;
        public event EventHandler UpdateTransactionTable;
        public MainPresenter presenter;        
        private int currentUserId;
        private int currentCombatId;
        private int editCellRow;
        private int editCellColumn;
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
        public int CurrentUserId
        {
            get { return currentUserId; }
        }
        public int CurrentCombatId
        {
            get { return currentCombatId; }
        }
        public int EditCell
        {
            get { return editCellRow; }
        }
        public object MainTable 
        {
            set { PlayerDGV.DataSource = value; } 
        }
        public object TransactionTable
        {
            get { return TransactionDGV.Rows[editCellRow].Cells[editCellColumn].Value ; }
            set { TransactionDGV.DataSource = value; }
        }
        public object CombatTable
        {
            set { CombatDGV.DataSource = value; }
        }
        public object HitTable
        {
            set { HitDGV.DataSource = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {           
            if (LoadTable != null) { LoadTable(this, EventArgs.Empty); }
        }

        private void TopTenUsersBySumBtn_Click(object sender, EventArgs e)
        {
            if (TopTenUsersBySum != null) { TopTenUsersBySum(this, EventArgs.Empty); }
        }

        private void ValidEMailBtn_Click(object sender, EventArgs e)
        {
            if (ValidEMail != null) { ValidEMail(this, EventArgs.Empty); }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (LoadTable != null) { LoadTable(this, EventArgs.Empty); }
        }        
        
        private void PlayerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentUserId = (int)PlayerDGV[0, e.RowIndex].Value; 
            } 
            LoadDetail();
        }
        public void LoadDetail()
        {
            if (LoadTransaction != null) { LoadTransaction(this, EventArgs.Empty); }
            if (LoadCombat != null) { LoadCombat(this, EventArgs.Empty); }            
        }

        private void CombatDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentCombatId = (int)CombatDGV[0, e.RowIndex].Value; 
            }            
            if (LoadHit != null) { LoadHit(this, EventArgs.Empty); }
        }

        private void TransactionDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {            
            if (UpdateTransactionTable != null) { UpdateTransactionTable(this, EventArgs.Empty); }
        }

        private void TransactionDGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editCellRow = (int)TransactionDGV[0, e.RowIndex].Value;
            editCellColumn = e.ColumnIndex;
        }        
    }
}
