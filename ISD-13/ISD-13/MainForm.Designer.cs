﻿namespace ISD_13
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ValidEmailCB = new System.Windows.Forms.CheckBox();
            this.PlayerDGV = new System.Windows.Forms.DataGridView();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.TransactionsTab = new System.Windows.Forms.TabPage();
            this.TransactionDGV = new System.Windows.Forms.DataGridView();
            this.CombatsTab = new System.Windows.Forms.TabPage();
            this.CombatDGV = new System.Windows.Forms.DataGridView();
            this.HitsTab = new System.Windows.Forms.TabPage();
            this.HitDGV = new System.Windows.Forms.DataGridView();
            this.CurrentPlayerTxt = new System.Windows.Forms.TextBox();
            this.PlayerLbl = new System.Windows.Forms.Label();
            this.CombatIdLbl = new System.Windows.Forms.Label();
            this.CurrentCombatIdTxt = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatTypePVPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firstPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).BeginInit();
            this.MainTab.SuspendLayout();
            this.PlayersTab.SuspendLayout();
            this.TransactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).BeginInit();
            this.CombatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CombatDGV)).BeginInit();
            this.HitsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HitDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(753, 279);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ValidEmailCB
            // 
            this.ValidEmailCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ValidEmailCB.AutoSize = true;
            this.ValidEmailCB.Location = new System.Drawing.Point(12, 311);
            this.ValidEmailCB.Name = "ValidEmailCB";
            this.ValidEmailCB.Size = new System.Drawing.Size(77, 17);
            this.ValidEmailCB.TabIndex = 14;
            this.ValidEmailCB.Text = "Valid Email";
            this.ValidEmailCB.UseVisualStyleBackColor = true;
            this.ValidEmailCB.CheckedChanged += new System.EventHandler(this.ValidEmailCB_CheckedChanged);
            // 
            // PlayerDGV
            // 
            this.PlayerDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerDGV.AutoGenerateColumns = false;
            this.PlayerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.eMailValidDataGridViewCheckBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.combatsDataGridViewTextBoxColumn});
            this.PlayerDGV.DataSource = this.playerBindingSource;
            this.PlayerDGV.Location = new System.Drawing.Point(6, 6);
            this.PlayerDGV.Name = "PlayerDGV";
            this.PlayerDGV.Size = new System.Drawing.Size(800, 218);
            this.PlayerDGV.TabIndex = 16;
            this.PlayerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDGV_CellClick);
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.PlayersTab);
            this.MainTab.Controls.Add(this.TransactionsTab);
            this.MainTab.Controls.Add(this.CombatsTab);
            this.MainTab.Controls.Add(this.HitsTab);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(820, 256);
            this.MainTab.TabIndex = 17;
            this.MainTab.Click += new System.EventHandler(this.MainTab_Click);
            // 
            // PlayersTab
            // 
            this.PlayersTab.Controls.Add(this.PlayerDGV);
            this.PlayersTab.Location = new System.Drawing.Point(4, 22);
            this.PlayersTab.Name = "PlayersTab";
            this.PlayersTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTab.Size = new System.Drawing.Size(812, 230);
            this.PlayersTab.TabIndex = 0;
            this.PlayersTab.Text = "Players";
            this.PlayersTab.UseVisualStyleBackColor = true;
            // 
            // TransactionsTab
            // 
            this.TransactionsTab.Controls.Add(this.TransactionDGV);
            this.TransactionsTab.Location = new System.Drawing.Point(4, 22);
            this.TransactionsTab.Name = "TransactionsTab";
            this.TransactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionsTab.Size = new System.Drawing.Size(812, 230);
            this.TransactionsTab.TabIndex = 1;
            this.TransactionsTab.Text = "Transactions";
            this.TransactionsTab.UseVisualStyleBackColor = true;
            // 
            // TransactionDGV
            // 
            this.TransactionDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionDGV.AutoGenerateColumns = false;
            this.TransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.playerDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6});
            this.TransactionDGV.DataSource = this.transactionBindingSource;
            this.TransactionDGV.Location = new System.Drawing.Point(6, 6);
            this.TransactionDGV.Name = "TransactionDGV";
            this.TransactionDGV.Size = new System.Drawing.Size(746, 230);
            this.TransactionDGV.TabIndex = 17;
            // 
            // CombatsTab
            // 
            this.CombatsTab.Controls.Add(this.CombatDGV);
            this.CombatsTab.Location = new System.Drawing.Point(4, 22);
            this.CombatsTab.Name = "CombatsTab";
            this.CombatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CombatsTab.Size = new System.Drawing.Size(812, 230);
            this.CombatsTab.TabIndex = 2;
            this.CombatsTab.Text = "Combats";
            this.CombatsTab.UseVisualStyleBackColor = true;
            // 
            // CombatDGV
            // 
            this.CombatDGV.AllowUserToAddRows = false;
            this.CombatDGV.AllowUserToDeleteRows = false;
            this.CombatDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatDGV.AutoGenerateColumns = false;
            this.CombatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CombatDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.combatTypePVPDataGridViewCheckBoxColumn,
            this.firstPlayerDataGridViewTextBoxColumn,
            this.secondPlayerDataGridViewTextBoxColumn,
            this.winnerDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.playersDataGridViewTextBoxColumn});
            this.CombatDGV.DataSource = this.combatBindingSource;
            this.CombatDGV.Location = new System.Drawing.Point(6, 6);
            this.CombatDGV.Name = "CombatDGV";
            this.CombatDGV.ReadOnly = true;
            this.CombatDGV.Size = new System.Drawing.Size(746, 230);
            this.CombatDGV.TabIndex = 17;
            this.CombatDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CombatDGV_CellClick);
            // 
            // HitsTab
            // 
            this.HitsTab.Controls.Add(this.HitDGV);
            this.HitsTab.Location = new System.Drawing.Point(4, 22);
            this.HitsTab.Name = "HitsTab";
            this.HitsTab.Padding = new System.Windows.Forms.Padding(3);
            this.HitsTab.Size = new System.Drawing.Size(812, 230);
            this.HitsTab.TabIndex = 3;
            this.HitsTab.Text = "Hits";
            this.HitsTab.UseVisualStyleBackColor = true;
            // 
            // HitDGV
            // 
            this.HitDGV.AllowUserToAddRows = false;
            this.HitDGV.AllowUserToDeleteRows = false;
            this.HitDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HitDGV.AutoGenerateColumns = false;
            this.HitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HitDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.hitValueDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.combatDataGridViewTextBoxColumn});
            this.HitDGV.DataSource = this.hitLogBindingSource;
            this.HitDGV.Location = new System.Drawing.Point(6, 6);
            this.HitDGV.Name = "HitDGV";
            this.HitDGV.ReadOnly = true;
            this.HitDGV.Size = new System.Drawing.Size(746, 230);
            this.HitDGV.TabIndex = 17;
            // 
            // CurrentPlayerTxt
            // 
            this.CurrentPlayerTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentPlayerTxt.Location = new System.Drawing.Point(57, 281);
            this.CurrentPlayerTxt.Name = "CurrentPlayerTxt";
            this.CurrentPlayerTxt.Size = new System.Drawing.Size(328, 20);
            this.CurrentPlayerTxt.TabIndex = 18;
            // 
            // PlayerLbl
            // 
            this.PlayerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayerLbl.AutoSize = true;
            this.PlayerLbl.Location = new System.Drawing.Point(12, 284);
            this.PlayerLbl.Name = "PlayerLbl";
            this.PlayerLbl.Size = new System.Drawing.Size(42, 13);
            this.PlayerLbl.TabIndex = 19;
            this.PlayerLbl.Text = "Player :";
            // 
            // CombatIdLbl
            // 
            this.CombatIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CombatIdLbl.AutoSize = true;
            this.CombatIdLbl.Location = new System.Drawing.Point(414, 284);
            this.CombatIdLbl.Name = "CombatIdLbl";
            this.CombatIdLbl.Size = new System.Drawing.Size(58, 13);
            this.CombatIdLbl.TabIndex = 21;
            this.CombatIdLbl.Text = "CombatId :";
            // 
            // CurrentCombatIdTxt
            // 
            this.CurrentCombatIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentCombatIdTxt.Location = new System.Drawing.Point(475, 281);
            this.CurrentCombatIdTxt.Name = "CurrentCombatIdTxt";
            this.CurrentCombatIdTxt.Size = new System.Drawing.Size(270, 20);
            this.CurrentCombatIdTxt.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // playerDataGridViewTextBoxColumn
            // 
            this.playerDataGridViewTextBoxColumn.DataPropertyName = "Player";
            this.playerDataGridViewTextBoxColumn.HeaderText = "Player";
            this.playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(ISD_13.Data.Transaction);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // combatTypePVPDataGridViewCheckBoxColumn
            // 
            this.combatTypePVPDataGridViewCheckBoxColumn.DataPropertyName = "CombatTypePVP";
            this.combatTypePVPDataGridViewCheckBoxColumn.HeaderText = "CombatTypePVP";
            this.combatTypePVPDataGridViewCheckBoxColumn.Name = "combatTypePVPDataGridViewCheckBoxColumn";
            this.combatTypePVPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // firstPlayerDataGridViewTextBoxColumn
            // 
            this.firstPlayerDataGridViewTextBoxColumn.DataPropertyName = "FirstPlayer";
            this.firstPlayerDataGridViewTextBoxColumn.HeaderText = "FirstPlayer";
            this.firstPlayerDataGridViewTextBoxColumn.Name = "firstPlayerDataGridViewTextBoxColumn";
            this.firstPlayerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondPlayerDataGridViewTextBoxColumn
            // 
            this.secondPlayerDataGridViewTextBoxColumn.DataPropertyName = "SecondPlayer";
            this.secondPlayerDataGridViewTextBoxColumn.HeaderText = "SecondPlayer";
            this.secondPlayerDataGridViewTextBoxColumn.Name = "secondPlayerDataGridViewTextBoxColumn";
            this.secondPlayerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // winnerDataGridViewTextBoxColumn
            // 
            this.winnerDataGridViewTextBoxColumn.DataPropertyName = "Winner";
            this.winnerDataGridViewTextBoxColumn.HeaderText = "Winner";
            this.winnerDataGridViewTextBoxColumn.Name = "winnerDataGridViewTextBoxColumn";
            this.winnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            this.playersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // combatBindingSource
            // 
            this.combatBindingSource.DataSource = typeof(ISD_13.Data.Combat);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // hitValueDataGridViewTextBoxColumn
            // 
            this.hitValueDataGridViewTextBoxColumn.DataPropertyName = "HitValue";
            this.hitValueDataGridViewTextBoxColumn.HeaderText = "HitValue";
            this.hitValueDataGridViewTextBoxColumn.Name = "hitValueDataGridViewTextBoxColumn";
            this.hitValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "Part";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            this.partDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // combatDataGridViewTextBoxColumn
            // 
            this.combatDataGridViewTextBoxColumn.DataPropertyName = "Combat";
            this.combatDataGridViewTextBoxColumn.HeaderText = "Combat";
            this.combatDataGridViewTextBoxColumn.Name = "combatDataGridViewTextBoxColumn";
            this.combatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hitLogBindingSource
            // 
            this.hitLogBindingSource.DataSource = typeof(ISD_13.Data.HitLog);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ISD_13.Data.Player);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // eMailValidDataGridViewCheckBoxColumn
            // 
            this.eMailValidDataGridViewCheckBoxColumn.DataPropertyName = "EMailValid";
            this.eMailValidDataGridViewCheckBoxColumn.HeaderText = "EMailValid";
            this.eMailValidDataGridViewCheckBoxColumn.Name = "eMailValidDataGridViewCheckBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // combatsDataGridViewTextBoxColumn
            // 
            this.combatsDataGridViewTextBoxColumn.DataPropertyName = "Combats";
            this.combatsDataGridViewTextBoxColumn.HeaderText = "Combats";
            this.combatsDataGridViewTextBoxColumn.Name = "combatsDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 335);
            this.Controls.Add(this.CombatIdLbl);
            this.Controls.Add(this.CurrentCombatIdTxt);
            this.Controls.Add(this.PlayerLbl);
            this.Controls.Add(this.CurrentPlayerTxt);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ValidEmailCB);
            this.Name = "MainForm";
            this.Text = "Combats";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.PlayersTab.ResumeLayout(false);
            this.TransactionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).EndInit();
            this.CombatsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CombatDGV)).EndInit();
            this.HitsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HitDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox ValidEmailCB;
        private System.Windows.Forms.DataGridView PlayerDGV;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage PlayersTab;
        private System.Windows.Forms.TabPage TransactionsTab;
        private System.Windows.Forms.TabPage CombatsTab;
        private System.Windows.Forms.TabPage HitsTab;
        private System.Windows.Forms.DataGridView TransactionDGV;
        private System.Windows.Forms.DataGridView CombatDGV;
        private System.Windows.Forms.DataGridView HitDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn combatTypePVPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource combatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn combatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hitLogBindingSource;
        private System.Windows.Forms.TextBox CurrentPlayerTxt;
        private System.Windows.Forms.Label PlayerLbl;
        private System.Windows.Forms.Label CombatIdLbl;
        private System.Windows.Forms.TextBox CurrentCombatIdTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMailValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn combatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;

    }
}

