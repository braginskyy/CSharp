namespace ISD_10
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBot = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.ProgressBar();
            this.pbBot = new System.Windows.Forms.ProgressBar();
            this.lblPlayerXp = new System.Windows.Forms.Label();
            this.lblBotXp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBodyBlock = new System.Windows.Forms.RadioButton();
            this.rbLegsBlock = new System.Windows.Forms.RadioButton();
            this.rbHeadBlock = new System.Windows.Forms.RadioButton();
            this.rbHeadFight = new System.Windows.Forms.RadioButton();
            this.rbLegsFight = new System.Windows.Forms.RadioButton();
            this.rbBodyFight = new System.Windows.Forms.RadioButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.butFight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbArmorPlayer = new System.Windows.Forms.ProgressBar();
            this.pbStrengthPlayer = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbStrengthBot = new System.Windows.Forms.ProgressBar();
            this.pbArmorBot = new System.Windows.Forms.ProgressBar();
            this.butArmorPlayer = new System.Windows.Forms.Button();
            this.butStrengthPlayer = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblStatPlayerStrength = new System.Windows.Forms.Label();
            this.lblStatPlayerArmor = new System.Windows.Forms.Label();
            this.lblStatBotStrength = new System.Windows.Forms.Label();
            this.lblStatBotArmor = new System.Windows.Forms.Label();
            this.butNextBatl = new System.Windows.Forms.Button();
            this.butRestart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(27, 26);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(38, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Игрок";
            // 
            // lblBot
            // 
            this.lblBot.AutoSize = true;
            this.lblBot.Location = new System.Drawing.Point(327, 26);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(25, 13);
            this.lblBot.TabIndex = 1;
            this.lblBot.Text = "Бот";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(30, 45);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(225, 10);
            this.pbPlayer.Step = 1;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.Value = 100;
            // 
            // pbBot
            // 
            this.pbBot.Location = new System.Drawing.Point(325, 45);
            this.pbBot.Name = "pbBot";
            this.pbBot.Size = new System.Drawing.Size(225, 10);
            this.pbBot.Step = 1;
            this.pbBot.TabIndex = 3;
            this.pbBot.Value = 100;
            // 
            // lblPlayerXp
            // 
            this.lblPlayerXp.AutoSize = true;
            this.lblPlayerXp.Location = new System.Drawing.Point(71, 26);
            this.lblPlayerXp.Name = "lblPlayerXp";
            this.lblPlayerXp.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerXp.TabIndex = 4;
            // 
            // lblBotXp
            // 
            this.lblBotXp.AutoSize = true;
            this.lblBotXp.Location = new System.Drawing.Point(358, 26);
            this.lblBotXp.Name = "lblBotXp";
            this.lblBotXp.Size = new System.Drawing.Size(0, 13);
            this.lblBotXp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Блок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Удар";
            // 
            // rbBodyBlock
            // 
            this.rbBodyBlock.AutoSize = true;
            this.rbBodyBlock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBodyBlock.Location = new System.Drawing.Point(18, 44);
            this.rbBodyBlock.Name = "rbBodyBlock";
            this.rbBodyBlock.Size = new System.Drawing.Size(55, 17);
            this.rbBodyBlock.TabIndex = 9;
            this.rbBodyBlock.Text = "Корус";
            this.rbBodyBlock.UseVisualStyleBackColor = true;
            // 
            // rbLegsBlock
            // 
            this.rbLegsBlock.AutoSize = true;
            this.rbLegsBlock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbLegsBlock.Location = new System.Drawing.Point(23, 70);
            this.rbLegsBlock.Name = "rbLegsBlock";
            this.rbLegsBlock.Size = new System.Drawing.Size(50, 17);
            this.rbLegsBlock.TabIndex = 10;
            this.rbLegsBlock.Text = "Ноги";
            this.rbLegsBlock.UseVisualStyleBackColor = true;
            // 
            // rbHeadBlock
            // 
            this.rbHeadBlock.AutoSize = true;
            this.rbHeadBlock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHeadBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHeadBlock.Location = new System.Drawing.Point(12, 16);
            this.rbHeadBlock.Name = "rbHeadBlock";
            this.rbHeadBlock.Size = new System.Drawing.Size(61, 17);
            this.rbHeadBlock.TabIndex = 11;
            this.rbHeadBlock.Text = "Голова";
            this.rbHeadBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHeadBlock.UseVisualStyleBackColor = true;
            // 
            // rbHeadFight
            // 
            this.rbHeadFight.AutoSize = true;
            this.rbHeadFight.Location = new System.Drawing.Point(13, 16);
            this.rbHeadFight.Name = "rbHeadFight";
            this.rbHeadFight.Size = new System.Drawing.Size(61, 17);
            this.rbHeadFight.TabIndex = 14;
            this.rbHeadFight.Text = "Голова";
            this.rbHeadFight.UseVisualStyleBackColor = true;
            // 
            // rbLegsFight
            // 
            this.rbLegsFight.AutoSize = true;
            this.rbLegsFight.Location = new System.Drawing.Point(13, 70);
            this.rbLegsFight.Name = "rbLegsFight";
            this.rbLegsFight.Size = new System.Drawing.Size(50, 17);
            this.rbLegsFight.TabIndex = 13;
            this.rbLegsFight.Text = "Ноги";
            this.rbLegsFight.UseVisualStyleBackColor = true;
            // 
            // rbBodyFight
            // 
            this.rbBodyFight.AutoSize = true;
            this.rbBodyFight.Location = new System.Drawing.Point(13, 44);
            this.rbBodyFight.Name = "rbBodyFight";
            this.rbBodyFight.Size = new System.Drawing.Size(61, 17);
            this.rbBodyFight.TabIndex = 12;
            this.rbBodyFight.Text = "Корпус";
            this.rbBodyFight.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(30, 280);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(519, 256);
            this.txtLog.TabIndex = 15;
            // 
            // butFight
            // 
            this.butFight.Location = new System.Drawing.Point(252, 245);
            this.butFight.Name = "butFight";
            this.butFight.Size = new System.Drawing.Size(75, 23);
            this.butFight.TabIndex = 16;
            this.butFight.Text = "Бой";
            this.butFight.UseVisualStyleBackColor = true;
            this.butFight.Click += new System.EventHandler(this.butFight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHeadBlock);
            this.groupBox1.Controls.Add(this.rbLegsBlock);
            this.groupBox1.Controls.Add(this.rbBodyBlock);
            this.groupBox1.Location = new System.Drawing.Point(168, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 105);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHeadFight);
            this.groupBox2.Controls.Add(this.rbLegsFight);
            this.groupBox2.Controls.Add(this.rbBodyFight);
            this.groupBox2.Location = new System.Drawing.Point(325, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 105);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbArmorPlayer
            // 
            this.pbArmorPlayer.Location = new System.Drawing.Point(30, 255);
            this.pbArmorPlayer.Name = "pbArmorPlayer";
            this.pbArmorPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbArmorPlayer.Size = new System.Drawing.Size(145, 12);
            this.pbArmorPlayer.TabIndex = 21;
            // 
            // pbStrengthPlayer
            // 
            this.pbStrengthPlayer.Location = new System.Drawing.Point(30, 223);
            this.pbStrengthPlayer.Name = "pbStrengthPlayer";
            this.pbStrengthPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbStrengthPlayer.Size = new System.Drawing.Size(145, 12);
            this.pbStrengthPlayer.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Атака";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Защита";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Защита";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Атака";
            // 
            // pbStrengthBot
            // 
            this.pbStrengthBot.Location = new System.Drawing.Point(404, 223);
            this.pbStrengthBot.Name = "pbStrengthBot";
            this.pbStrengthBot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbStrengthBot.Size = new System.Drawing.Size(145, 12);
            this.pbStrengthBot.TabIndex = 29;
            // 
            // pbArmorBot
            // 
            this.pbArmorBot.Location = new System.Drawing.Point(404, 255);
            this.pbArmorBot.Name = "pbArmorBot";
            this.pbArmorBot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pbArmorBot.Size = new System.Drawing.Size(145, 12);
            this.pbArmorBot.TabIndex = 28;
            // 
            // butArmorPlayer
            // 
            this.butArmorPlayer.Location = new System.Drawing.Point(186, 248);
            this.butArmorPlayer.Name = "butArmorPlayer";
            this.butArmorPlayer.Size = new System.Drawing.Size(28, 20);
            this.butArmorPlayer.TabIndex = 35;
            this.butArmorPlayer.Text = "+1";
            this.butArmorPlayer.UseVisualStyleBackColor = true;
            this.butArmorPlayer.Click += new System.EventHandler(this.butArmorPlayer_Click);
            // 
            // butStrengthPlayer
            // 
            this.butStrengthPlayer.Location = new System.Drawing.Point(186, 216);
            this.butStrengthPlayer.Name = "butStrengthPlayer";
            this.butStrengthPlayer.Size = new System.Drawing.Size(28, 20);
            this.butStrengthPlayer.TabIndex = 34;
            this.butStrengthPlayer.Text = "+1";
            this.butStrengthPlayer.UseVisualStyleBackColor = true;
            this.butStrengthPlayer.Click += new System.EventHandler(this.butStrengthPlayer_Click);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(192, 197);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(196, 13);
            this.lblStat.TabIndex = 36;
            this.lblStat.Text = "У вас осталось 10 свободных статов";
            // 
            // lblStatPlayerStrength
            // 
            this.lblStatPlayerStrength.AutoSize = true;
            this.lblStatPlayerStrength.Location = new System.Drawing.Point(181, 222);
            this.lblStatPlayerStrength.Name = "lblStatPlayerStrength";
            this.lblStatPlayerStrength.Size = new System.Drawing.Size(0, 13);
            this.lblStatPlayerStrength.TabIndex = 37;
            this.lblStatPlayerStrength.Visible = false;
            // 
            // lblStatPlayerArmor
            // 
            this.lblStatPlayerArmor.AutoSize = true;
            this.lblStatPlayerArmor.Location = new System.Drawing.Point(181, 254);
            this.lblStatPlayerArmor.Name = "lblStatPlayerArmor";
            this.lblStatPlayerArmor.Size = new System.Drawing.Size(0, 13);
            this.lblStatPlayerArmor.TabIndex = 38;
            this.lblStatPlayerArmor.Visible = false;
            // 
            // lblStatBotStrength
            // 
            this.lblStatBotStrength.AutoSize = true;
            this.lblStatBotStrength.Location = new System.Drawing.Point(388, 223);
            this.lblStatBotStrength.Name = "lblStatBotStrength";
            this.lblStatBotStrength.Size = new System.Drawing.Size(0, 13);
            this.lblStatBotStrength.TabIndex = 39;
            this.lblStatBotStrength.Visible = false;
            // 
            // lblStatBotArmor
            // 
            this.lblStatBotArmor.AutoSize = true;
            this.lblStatBotArmor.Location = new System.Drawing.Point(388, 254);
            this.lblStatBotArmor.Name = "lblStatBotArmor";
            this.lblStatBotArmor.Size = new System.Drawing.Size(0, 13);
            this.lblStatBotArmor.TabIndex = 40;
            this.lblStatBotArmor.Visible = false;
            // 
            // butNextBatl
            // 
            this.butNextBatl.Enabled = false;
            this.butNextBatl.Location = new System.Drawing.Point(252, 215);
            this.butNextBatl.Name = "butNextBatl";
            this.butNextBatl.Size = new System.Drawing.Size(75, 23);
            this.butNextBatl.TabIndex = 42;
            this.butNextBatl.Text = "След. раунд";
            this.butNextBatl.UseVisualStyleBackColor = true;
            this.butNextBatl.Click += new System.EventHandler(this.butNextBatl_Click);
            // 
            // butRestart
            // 
            this.butRestart.Location = new System.Drawing.Point(261, 33);
            this.butRestart.Name = "butRestart";
            this.butRestart.Size = new System.Drawing.Size(58, 23);
            this.butRestart.TabIndex = 43;
            this.butRestart.Text = "Рестарт";
            this.butRestart.UseVisualStyleBackColor = true;
            this.butRestart.Click += new System.EventHandler(this.butRestart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.butRestart);
            this.Controls.Add(this.butNextBatl);
            this.Controls.Add(this.lblStatBotArmor);
            this.Controls.Add(this.lblStatBotStrength);
            this.Controls.Add(this.lblStatPlayerArmor);
            this.Controls.Add(this.lblStatPlayerStrength);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.butArmorPlayer);
            this.Controls.Add(this.butStrengthPlayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbStrengthBot);
            this.Controls.Add(this.pbArmorBot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbStrengthPlayer);
            this.Controls.Add(this.pbArmorPlayer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butFight);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBotXp);
            this.Controls.Add(this.lblPlayerXp);
            this.Controls.Add(this.pbBot);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblBot);
            this.Controls.Add(this.lblPlayer);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Text = " Бойцовский клуб";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.ProgressBar pbPlayer;
        private System.Windows.Forms.ProgressBar pbBot;
        private System.Windows.Forms.Label lblPlayerXp;
        private System.Windows.Forms.Label lblBotXp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBodyBlock;
        private System.Windows.Forms.RadioButton rbLegsBlock;
        private System.Windows.Forms.RadioButton rbHeadBlock;
        private System.Windows.Forms.RadioButton rbHeadFight;
        private System.Windows.Forms.RadioButton rbLegsFight;
        private System.Windows.Forms.RadioButton rbBodyFight;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button butFight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar pbArmorPlayer;
        private System.Windows.Forms.ProgressBar pbStrengthPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbStrengthBot;
        private System.Windows.Forms.ProgressBar pbArmorBot;
        private System.Windows.Forms.Button butArmorPlayer;
        private System.Windows.Forms.Button butStrengthPlayer;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblStatPlayerStrength;
        private System.Windows.Forms.Label lblStatPlayerArmor;
        private System.Windows.Forms.Label lblStatBotStrength;
        private System.Windows.Forms.Label lblStatBotArmor;
        private System.Windows.Forms.Button butNextBatl;
        private System.Windows.Forms.Button butRestart;
    }
}

