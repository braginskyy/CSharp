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
        int PlayerHp { set; }
        string BotName { set; }
        int BotHp { set; }
        int GetHit { get; }
        int GetBlock { get; }
        string Log { set; }
        int PlayerStrength { get; }
        int PlayerArmor { get; }
        int BotStrength { set; }
        int BotArmor { set; }
        event EventHandler FightClick;
    }
    public partial class MainForm : Form, IMainForm
    {
        Presenter present = null;
        public event EventHandler FightClick;
        int hit;
        int block;
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
            set
            {
                lblBotXp.Text = value.ToString();
                bpBot.Value = value;
            }
        }
        public int GetHit
        {
            get { return hit; }
        }
        public int GetBlock
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
        private void butFight_Click(object sender, EventArgs e)
        {            
            lblStatPlayerStrength.Text = (pbStrengthPlayer.Value/10).ToString();
            lblStatPlayerArmor.Text = (pbArmorPlayer.Value / 10).ToString(); 
            VisibleControl();
            CheckRadioButton();            
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
        private void CheckRadioButton()
        {
            if (rbHeadBlock.Checked) { block = (int)Position.Head; }
            if (rbBodyBlock.Checked) { block = (int)Position.Body; }
            if (rbLegsBlock.Checked) { block = (int)Position.Legs; }
            if (rbHeadFight.Checked) { hit = (int)Position.Head; }
            if (rbBodyFight.Checked) { hit = (int)Position.Body; }
            if (rbLegsFight.Checked) { hit = (int)Position.Legs; }
            if (rbHeadBlock.Checked == rbBodyBlock.Checked == rbLegsBlock.Checked &&
                rbHeadFight.Checked == rbBodyFight.Checked == rbLegsFight.Checked)
            {
                if (pbPlayer.Value != 0 && bpBot.Value != 0)
                {
                    if (FightClick != null) { FightClick(this, EventArgs.Empty); }
                }
            }
            rbHeadBlock.Checked = rbBodyBlock.Checked = rbLegsBlock.Checked = false;
            rbHeadFight.Checked = rbBodyFight.Checked = rbLegsFight.Checked = false;           
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void butStrengthPlayer_Click(object sender, EventArgs e)
        {
            if (pbStrengthPlayer.Value < 100)
            {
                if (pbStrengthPlayer.Value + pbArmorPlayer.Value < 100)
                {
                    pbStrengthPlayer.Value += 10;
                    lblStat.Text = "У вас осталось " + (100 - (pbArmorPlayer.Value + pbStrengthPlayer.Value)) / 10 + " свободных статов";
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
            if (pbArmorPlayer.Value < 100)
            {
                if (pbStrengthPlayer.Value + pbArmorPlayer.Value < 100)
                {
                    pbArmorPlayer.Value += 10;
                    lblStat.Text = "У вас осталось " + (100 - (pbArmorPlayer.Value + pbStrengthPlayer.Value)) / 10 + " свободных статов";
                }
                else
                {
                    pbStrengthPlayer.Value -= 10;
                    pbArmorPlayer.Value += 10;
                }
            }
        }
    }
}
