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
        public event EventHandler LoadPlayerTables;
        public event EventHandler SavePlayer;        
        public MainPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);            
        }
        public object PlayerTable
        {
            set { PlayerDGV.DataSource = value; }
        }
        public bool ValidEmailCBStatus
        {
            get { return ValidEmailCB.Checked; }
        }
        public bool TopTenUsersBySumCBStatus
        {
            get { return TopTenUsersBySumCB.Checked; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            if (LoadPlayerTables != null) { LoadPlayerTables(this, EventArgs.Empty); }
        } 
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SavePlayer != null) { SavePlayer(this, EventArgs.Empty); }
            if (LoadPlayerTables != null) { LoadPlayerTables(this, EventArgs.Empty); }            
        }

        private void ValidEmailCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadPlayerTables != null) { LoadPlayerTables(this, EventArgs.Empty); } 
        }

        private void TopTenUsersBySumCB_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadPlayerTables != null) { LoadPlayerTables(this, EventArgs.Empty); }
        }
    }
}
