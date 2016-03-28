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
        public MainPresenter presenter;
        public int currentUserId;
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
        public int CurrentUserId
        {
            get { return currentUserId; }
        }
        public object MainTable 
        {
            set { PlayerDGV.DataSource = value; } 
        }
        public object TransactionTable
        {
            set { TransactionDGV.DataSource = value; }
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

        private void PlayerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void LoadDetail()
        {
            if (LoadTransaction != null) { LoadTransaction(this, EventArgs.Empty); }
        }

        private void PlayerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentUserId = (int)PlayerDGV[0, e.RowIndex].Value;
            LoadDetail();
        }            
    }
}
