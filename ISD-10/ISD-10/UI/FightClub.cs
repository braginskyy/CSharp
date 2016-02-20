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
        string PlayerName { set; }
        int PlayerHp { get; set; }
        string BotName { set; }
        int BotHp { get; set; }
        Position Hit { get; }
        Position Block { get; }
        string Log { set; }
        string LabelStat { set; }      
        int BotStrength { set; }
        int BotArmor { set; }
        int PBPlayerMax { set; get; }
        int PBBotMax { set; get; }
        int PBStrengthPlayer { get; set; }
        int PBArmorPlayer { get; set; }
        int PBStrengthBot { get; set; }
        int PBArmorBot { get; set; }
        int PBStrengthPlayerMax { get; set; }
        int PBArmorPlayerMax { get; set; }
        int PBStrengthBotMax { get; set; }
        int PBArmorBotMax { get; set; }
        event EventHandler FightClick;
        event EventHandler NextBatle;
        event EventHandler PlayerStrengthAdd;
        event EventHandler PlayerArmorAdd;
    }
    public partial class MainForm : Form, IMainForm
    {        
        Presenter present = null;
        public event EventHandler FightClick;
        public event EventHandler NextBatle;
        public event EventHandler PlayerStrengthAdd;
        public event EventHandler PlayerArmorAdd;
        Position hit;
        Position block;
        public MainForm()
        {            
            InitializeComponent();
            present = new Presenter(this);            
        }
        public string PlayerName
        {
            set { lblPlayer.Text = value; }
        }
        public int PlayerHp
        {
            get { return pbPlayer.Value; }
            set
            {
                lblPlayerXp.Text = value.ToString();
                pbPlayer.Value = value;
            }
        }
        public string BotName
        {
            set { lblBot.Text = value; }
        }
        public int BotHp
        {
            get { return pbBot.Value; }
            set
            {
                lblBotXp.Text = value.ToString();
                pbBot.Value = value;
            }
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
            set { lblStat.Text = value; }
        }
        public int BotStrength
        {
            set
            {
                pbStrengthBot.Value = value;
                lblStatBotStrength.Text = (pbStrengthBot.Value).ToString();
            }
        }
        public int BotArmor
        {
            set
            {
                pbArmorBot.Value = value;
                lblStatBotArmor.Text = (pbArmorBot.Value).ToString();
            }
        }
        public int PBPlayerMax
        {
            get { return pbPlayer.Maximum; }
            set { pbPlayer.Maximum = value; }
        }
        public int PBBotMax
        {
            get { return pbBot.Maximum; }
            set { pbBot.Maximum = value; }
        }
        public int PBStrengthPlayer
        {
            get { return pbStrengthPlayer.Value; }
            set { pbStrengthPlayer.Value = value; }
        }
        public int PBArmorPlayer
        {
            get { return pbArmorPlayer.Value; }
            set { pbArmorPlayer.Value = value; }
        }
        public int PBStrengthBot
        {
            get { return pbStrengthBot.Value; }
            set { pbStrengthBot.Value = value; }
        }
        public int PBArmorBot
        {
            get { return pbArmorBot.Value; }
            set { pbArmorBot.Value = value; }
        }
        public int PBStrengthPlayerMax
        {
            get { return pbStrengthPlayer.Maximum; }
            set { pbStrengthPlayer.Maximum = value; }
        }
        public int PBArmorPlayerMax
        {
            get { return pbArmorPlayer.Maximum; }
            set { pbArmorPlayer.Maximum = value; }
        }
        public int PBStrengthBotMax
        {
            get { return pbStrengthBot.Maximum; }
            set { pbStrengthBot.Maximum = value; }
        }
        public int PBArmorBotMax
        {
            get { return pbArmorBot.Maximum; }
            set { pbArmorBot.Maximum = value; }
        }
        private void butFight_Click(object sender, EventArgs e)
        {
            lblStatPlayerStrength.Text = (pbStrengthPlayer.Value / 10).ToString();
            lblStatPlayerArmor.Text = (pbArmorPlayer.Value / 10).ToString();
            VisibleControl();
            CheckRadioButton();
        }              
        private void butStrengthPlayer_Click(object sender, EventArgs e)
        {
            if (PlayerStrengthAdd != null) { PlayerStrengthAdd(this, EventArgs.Empty); }
        }
        private void butArmorPlayer_Click(object sender, EventArgs e)
        {
            if (PlayerArmorAdd != null) { PlayerArmorAdd(this, EventArgs.Empty); }
        }
        private void butNextBatl_Click(object sender, EventArgs e)
        {
            if (NextBatle != null) { NextBatle(this, EventArgs.Empty); }
            UnVisibleControl();
        }
        private void butRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        } 
        private void VisibleControl()
        {
            butStrengthPlayer.Visible = false;
            butArmorPlayer.Visible = false;
            lblStat.Visible = false;
            lblStatPlayerStrength.Visible = true;
            lblStatPlayerArmor.Visible = true;
            lblStatBotStrength.Visible = true;
            lblStatBotArmor.Visible = true;
        }
        private void UnVisibleControl()
        {
            butNextBatl.Enabled = false;
            lblStatPlayerStrength.Visible = false;
            lblStatPlayerArmor.Visible = false;
            lblStatBotStrength.Visible = false;
            lblStatBotArmor.Visible = false;
            butArmorPlayer.Visible = true;
            butStrengthPlayer.Visible = true;
            lblStat.Visible = true;
        }       
        private void CheckRadioButton()
        {
            if (rbHeadBlock.Checked) { block = Position.Head; }
            if (rbBodyBlock.Checked) { block = Position.Body; }
            if (rbLegsBlock.Checked) { block = Position.Legs; }
            if (rbHeadFight.Checked) { hit = Position.Head; }
            if (rbBodyFight.Checked) { hit = Position.Body; }
            if (rbLegsFight.Checked) { hit = Position.Legs; }
            if (rbHeadBlock.Checked == rbBodyBlock.Checked == rbLegsBlock.Checked &&
                rbHeadFight.Checked == rbBodyFight.Checked == rbLegsFight.Checked)
            {
                if (pbPlayer.Value != 0 && pbBot.Value != 0)
                {
                    if (FightClick != null) { FightClick(this, EventArgs.Empty); }
                }
            }
            rbHeadBlock.Checked = rbBodyBlock.Checked = rbLegsBlock.Checked = false;
            rbHeadFight.Checked = rbBodyFight.Checked = rbLegsFight.Checked = false;
            if (pbBot.Value == 0 || pbPlayer.Value == 0)
            {
                butNextBatl.Enabled = true;                
            }
        }
    }
}
