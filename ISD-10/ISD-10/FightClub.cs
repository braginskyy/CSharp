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
        int PlayerStrength { get; }
        int PlayerArmor { get; }
        int BotStrength { set; }
        int BotArmor { set; }
        int PBPlayerMax { set; get; }
        int PBBotMax { set; get; }
        int PBStrengthPlayerMax { get; set; }
        int PBArmorPlayerMax { get; set; }
        int PBStrengthBotMax { get; set; }
        int PBArmorBotMax { get; set; }
        event EventHandler FightClick;        
    }
    public partial class MainForm : Form, IMainForm
    {
        Presenter present = null;
        public event EventHandler FightClick;               
        int BonusStat = 10;
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
        public int PlayerStrength
        {
            get { return pbStrengthPlayer.Value / 10; }
        }
        public int PlayerArmor
        {
            get { return pbArmorPlayer.Value / 10; }
        }
        public int BotStrength
        {
            set
            {
                pbStrengthBot.Value = value * 10;
                lblStatBotStrength.Text = (pbStrengthBot.Value / 10).ToString();
            }
        }
        public int BotArmor
        {
            set
            {
                pbArmorBot.Value = value * 10;
                lblStatBotArmor.Text = (pbArmorBot.Value / 10).ToString();
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
            if (pbStrengthPlayer.Value < pbStrengthPlayer.Maximum)
            {
                if (pbStrengthPlayer.Value + pbArmorPlayer.Value < pbStrengthPlayer.Maximum)
                {
                    pbStrengthPlayer.Value += 10;
                    lblStat.Text = "У вас осталось " + (pbStrengthPlayer.Maximum - (pbArmorPlayer.Value + pbStrengthPlayer.Value)) / 10 + " свободных статов";
                }
                else
                {
                    pbArmorPlayer.Value -= 10;
                    pbStrengthPlayer.Value += 10;
                }
            }
        }
        private void butArmorPlayer_Click(object sender, EventArgs e)
        {
            if (pbArmorPlayer.Value < pbArmorPlayer.Maximum)
            {
                if (pbStrengthPlayer.Value + pbArmorPlayer.Value < pbArmorPlayer.Maximum)
                {
                    pbArmorPlayer.Value += 10;
                    lblStat.Text = "У вас осталось " + (pbArmorPlayer.Maximum - (pbArmorPlayer.Value + pbStrengthPlayer.Value)) / 10 + " свободных статов";
                }
                else
                {
                    pbStrengthPlayer.Value -= 10;
                    pbArmorPlayer.Value += 10;
                }
            }
        }
        private void butNextBatl_Click(object sender, EventArgs e)
        {            
            if (PlayerHp == 0 && BotHp != 0)
            {
                BonusStat += 10;
                PBBotMax = PBBotMax + 20;
                present.SetHp();
                present.Setup();
                present.View();
                PBStrengthBotMax = PBStrengthBotMax + 100;
                PBArmorBotMax = PBArmorBotMax + 100;
                present.BotRandomStat(BonusStat);
            }
            if (BotHp == 0 && PlayerHp != 0)
            {                
                PBPlayerMax = PBPlayerMax + 10;
                present.SetHp();
                present.Setup();
                present.View();
                PBStrengthPlayerMax = PBStrengthPlayerMax + 50;
                PBArmorPlayerMax = PBArmorPlayerMax + 50;
                present.BotRandomStat(BonusStat);
            }
            if (PlayerHp == 0 && BotHp == 0)
            {
                PBPlayerMax = PBPlayerMax + 5;
                PBBotMax = PBBotMax + 5;
                present.SetHp();
                present.Setup();
                present.View();
                present.BotRandomStat(BonusStat);
            }            
            UnVisibleControl();
            lblStat.Text = "У вас осталось " + (pbStrengthPlayer.Maximum - (pbArmorPlayer.Value + pbStrengthPlayer.Value)) / 10 + " свободных статов";
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
