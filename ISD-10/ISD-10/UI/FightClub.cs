using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_10
{
    public interface IMainForm
    {
        string PlayerName { get; set; }
        int PlayerHp { get; set; }
        int PlayerStrengthProgress { get; set; }
        int PlayerArmorProgress { get; set; }
        int PlayerHpMaxProgress { set; get; }
        int PlayerStrengthMaxProgress { get; set; }
        int PlayerArmorMaxProgress { get; set; }
        string BotName { set; }
        int BotHp { get; set; }
        int BotStrengthProgress { get; set; }
        int BotArmorProgress { get; set; }
        int BotHpMaxProgress { set; get; }
        int BotStrengthMaxProgress { get; set; }
        int BotArmorMaxProgress { get; set; }
        Position Hit { get; }
        Position Block { get; }
        string Log { set; }
        string LabelStat { set; } 
        event EventHandler Fight;
        event EventHandler NextBatle;
        event EventHandler PlayerStrengthAdd;
        event EventHandler PlayerArmorAdd;
    }
    public partial class MainForm : Form, IMainForm
    {        
        Presenter present = null;        
        Position hit = Position.Legs;
        Position block = Position.Legs;
        public MainForm()
        {            
            InitializeComponent();
            present = new Presenter(this);
        }
        public string PlayerName
        {
            get { return playerNameLbl.Text; }
            set { playerNameLbl.Text = value; }
        }
        public int PlayerHp
        {
            get { return playerHpProgress.Value; }
            set
            {
                lblPlayerXp.Text = value.ToString();
                playerHpProgress.Value = value;
            }
        }
        public int PlayerStrengthProgress
        {
            get { return playerStrengthProgress.Value; }
            set { playerStrengthProgress.Value = value; }
        }
        public int PlayerArmorProgress
        {
            get { return playerArmorProgress.Value; }
            set { playerArmorProgress.Value = value; }
        }
        public int PlayerHpMaxProgress
        {
            get { return playerHpProgress.Maximum; }
            set { playerHpProgress.Maximum = value; }
        }
        public int PlayerStrengthMaxProgress
        {
            get { return playerStrengthProgress.Maximum; }
            set { playerStrengthProgress.Maximum = value; }
        }
        public int PlayerArmorMaxProgress
        {
            get { return playerArmorProgress.Maximum; }
            set { playerArmorProgress.Maximum = value; }
        }
        public string BotName
        {
            set { botNameLbl.Text = value; }
        }
        public int BotHp
        {
            get { return botHpProgress.Value; }
            set
            {
                lblBotXp.Text = value.ToString();
                botHpProgress.Value = value;
            }
        }
        public int BotStrengthProgress
        {
            get { return botStrengthProgress.Value; }
            set { botStrengthProgress.Value = value; }
        }
        public int BotArmorProgress
        {
            get { return botArmorProgress.Value; }
            set { botArmorProgress.Value = value; }
        }
        public int BotHpMaxProgress
        {
            get { return botHpProgress.Maximum; }
            set { botHpProgress.Maximum = value; }
        }
        public int BotStrengthMaxProgress
        {
            get { return botStrengthProgress.Maximum; }
            set { botStrengthProgress.Maximum = value; }
        }
        public int BotArmorMaxProgress
        {
            get { return botArmorProgress.Maximum; }
            set { botArmorProgress.Maximum = value; }
        }
        public Position Hit
        {
            get { return hit; }
        }
        public Position Block
        {
            get { return block; }
        }
        public string Log
        {
            set { txtLog.Text += value + Environment.NewLine; }
        }
        public string LabelStat
        {
            set { bonusStatLbl.Text = value; }
        }
        public event EventHandler Fight;
        public event EventHandler NextBatle;
        public event EventHandler PlayerStrengthAdd;
        public event EventHandler PlayerArmorAdd; 
        private void FightBtn_Click(object sender, EventArgs e)
        {
            playerStrengthLbl.Text = playerStrengthProgress.Value.ToString();
            playerArmorLbl.Text = playerArmorProgress.Value.ToString();
            botStrengthLbl.Text = (botStrengthProgress.Value).ToString();
            botArmorLbl.Text = (botArmorProgress.Value).ToString();
            VisibleControl();
            CheckRadioButton();
        }              
        private void PlayerStrengthBtn_Click(object sender, EventArgs e)
        {
            if (PlayerStrengthAdd != null) { PlayerStrengthAdd(this, EventArgs.Empty); }
        }
        private void PlayerArmorBtn_Click(object sender, EventArgs e)
        {
            if (PlayerArmorAdd != null) { PlayerArmorAdd(this, EventArgs.Empty); }
        }
        private void NextBatleBtn_Click(object sender, EventArgs e)
        {
            if (NextBatle != null) { NextBatle(this, EventArgs.Empty); }
            UnVisibleControl();
        }
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        } 
        private void VisibleControl()
        {
            playerStrengthBtn.Visible = false;
            playerArmorBtn.Visible = false;
            bonusStatLbl.Visible = false;
            playerStrengthLbl.Visible = true;
            playerArmorLbl.Visible = true;
            botStrengthLbl.Visible = true;
            botArmorLbl.Visible = true;
        }
        private void UnVisibleControl()
        {
            nextBatleBtn.Enabled = false;
            playerStrengthLbl.Visible = false;
            playerArmorLbl.Visible = false;
            botStrengthLbl.Visible = false;
            botArmorLbl.Visible = false;
            playerArmorBtn.Visible = true;
            playerStrengthBtn.Visible = true;
            bonusStatLbl.Visible = true;
        }       
        private void CheckRadioButton()
        {
            if (blockHeadRadioBtn.Checked) { block = Position.Head; }
            if (blockBodyRadioBtn.Checked) { block = Position.Body; }
            if (blockLegsRadioBtn.Checked) { block = Position.Legs; }
            if (hitHeadRadioBtn.Checked) { hit = Position.Head; }
            if (hitBodyRadioBtn.Checked) { hit = Position.Body; }
            if (hitLegsRadioBtn.Checked) { hit = Position.Legs; }
            if (blockHeadRadioBtn.Checked == blockBodyRadioBtn.Checked == blockLegsRadioBtn.Checked &&
                hitHeadRadioBtn.Checked == hitBodyRadioBtn.Checked == hitLegsRadioBtn.Checked)
            {
                if (playerHpProgress.Value != 0 && botHpProgress.Value != 0)
                {
                    if (Fight != null) { Fight(this, EventArgs.Empty); }
                }
            }
            blockHeadRadioBtn.Checked = blockBodyRadioBtn.Checked = blockLegsRadioBtn.Checked = false;
            hitHeadRadioBtn.Checked = hitBodyRadioBtn.Checked = hitLegsRadioBtn.Checked = false;
            if (botHpProgress.Value == 0 || playerHpProgress.Value == 0)
            {
                nextBatleBtn.Enabled = true;                
            }
        }        
    }

}
