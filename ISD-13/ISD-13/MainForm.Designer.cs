namespace ISD_13
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
            this.PlayerDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TopTenUsersBySumBtn = new System.Windows.Forms.Button();
            this.ValidEMailBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.TransactionDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CombatDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatTypePVPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.firstPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HitDGV = new System.Windows.Forms.DataGridView();
            this.hitValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CombatDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerDGV
            // 
            this.PlayerDGV.AutoGenerateColumns = false;
            this.PlayerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.eMailValidDataGridViewCheckBoxColumn});
            this.PlayerDGV.DataSource = this.playerBindingSource;
            this.PlayerDGV.Location = new System.Drawing.Point(12, 36);
            this.PlayerDGV.Name = "PlayerDGV";
            this.PlayerDGV.Size = new System.Drawing.Size(563, 223);
            this.PlayerDGV.TabIndex = 2;
            this.PlayerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDGV_CellClick);            
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ISD_13.Data.Player);
            // 
            // TopTenUsersBySumBtn
            // 
            this.TopTenUsersBySumBtn.Location = new System.Drawing.Point(12, 266);
            this.TopTenUsersBySumBtn.Name = "TopTenUsersBySumBtn";
            this.TopTenUsersBySumBtn.Size = new System.Drawing.Size(159, 23);
            this.TopTenUsersBySumBtn.TabIndex = 3;
            this.TopTenUsersBySumBtn.Text = "Топ 10 (по платежам)";
            this.TopTenUsersBySumBtn.UseVisualStyleBackColor = true;
            this.TopTenUsersBySumBtn.Click += new System.EventHandler(this.TopTenUsersBySumBtn_Click);
            // 
            // ValidEMailBtn
            // 
            this.ValidEMailBtn.Location = new System.Drawing.Point(191, 266);
            this.ValidEMailBtn.Name = "ValidEMailBtn";
            this.ValidEMailBtn.Size = new System.Drawing.Size(211, 23);
            this.ValidEMailBtn.TabIndex = 4;
            this.ValidEMailBtn.Text = "Выбрать записи с валидным email";
            this.ValidEMailBtn.UseVisualStyleBackColor = true;
            this.ValidEMailBtn.Click += new System.EventHandler(this.ValidEMailBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(423, 266);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(152, 23);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Сбросить фильтры";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // TransactionDGV
            // 
            this.TransactionDGV.AutoGenerateColumns = false;
            this.TransactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.sumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6});
            this.TransactionDGV.DataSource = this.transactionBindingSource;
            this.TransactionDGV.Location = new System.Drawing.Point(607, 63);
            this.TransactionDGV.Name = "TransactionDGV";
            this.TransactionDGV.Size = new System.Drawing.Size(370, 87);
            this.TransactionDGV.TabIndex = 6;
            this.TransactionDGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TransactionDGV_CellBeginEdit);
            this.TransactionDGV.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDGV_CellLeave);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // CombatDGV
            // 
            this.CombatDGV.AutoGenerateColumns = false;
            this.CombatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CombatDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.combatTypePVPDataGridViewCheckBoxColumn,
            this.firstPlayerDataGridViewTextBoxColumn,
            this.secondPlayerDataGridViewTextBoxColumn,
            this.winnerDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4});
            this.CombatDGV.DataSource = this.combatBindingSource;
            this.CombatDGV.Location = new System.Drawing.Point(12, 326);
            this.CombatDGV.Name = "CombatDGV";
            this.CombatDGV.Size = new System.Drawing.Size(765, 201);
            this.CombatDGV.TabIndex = 7;
            this.CombatDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CombatDGV_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // combatTypePVPDataGridViewCheckBoxColumn
            // 
            this.combatTypePVPDataGridViewCheckBoxColumn.DataPropertyName = "CombatTypePVP";
            this.combatTypePVPDataGridViewCheckBoxColumn.HeaderText = "CombatTypePVP";
            this.combatTypePVPDataGridViewCheckBoxColumn.Name = "combatTypePVPDataGridViewCheckBoxColumn";
            // 
            // firstPlayerDataGridViewTextBoxColumn
            // 
            this.firstPlayerDataGridViewTextBoxColumn.DataPropertyName = "FirstPlayer";
            this.firstPlayerDataGridViewTextBoxColumn.HeaderText = "FirstPlayer";
            this.firstPlayerDataGridViewTextBoxColumn.Name = "firstPlayerDataGridViewTextBoxColumn";
            // 
            // secondPlayerDataGridViewTextBoxColumn
            // 
            this.secondPlayerDataGridViewTextBoxColumn.DataPropertyName = "SecondPlayer";
            this.secondPlayerDataGridViewTextBoxColumn.HeaderText = "SecondPlayer";
            this.secondPlayerDataGridViewTextBoxColumn.Name = "secondPlayerDataGridViewTextBoxColumn";
            // 
            // winnerDataGridViewTextBoxColumn
            // 
            this.winnerDataGridViewTextBoxColumn.DataPropertyName = "Winner";
            this.winnerDataGridViewTextBoxColumn.HeaderText = "Winner";
            this.winnerDataGridViewTextBoxColumn.Name = "winnerDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // combatBindingSource
            // 
            this.combatBindingSource.DataSource = typeof(ISD_13.Data.Combat);
            // 
            // HitDGV
            // 
            this.HitDGV.AutoGenerateColumns = false;
            this.HitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HitDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hitValueDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5});
            this.HitDGV.DataSource = this.hitLogBindingSource;
            this.HitDGV.Location = new System.Drawing.Point(786, 326);
            this.HitDGV.Name = "HitDGV";
            this.HitDGV.Size = new System.Drawing.Size(467, 201);
            this.HitDGV.TabIndex = 8;
            // 
            // hitValueDataGridViewTextBoxColumn
            // 
            this.hitValueDataGridViewTextBoxColumn.DataPropertyName = "HitValue";
            this.hitValueDataGridViewTextBoxColumn.HeaderText = "HitValue";
            this.hitValueDataGridViewTextBoxColumn.Name = "hitValueDataGridViewTextBoxColumn";
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "Part";
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // hitLogBindingSource
            // 
            this.hitLogBindingSource.DataSource = typeof(ISD_13.Data.HitLog);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Бои";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Удары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Игроки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Платежи";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(652, 266);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 541);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HitDGV);
            this.Controls.Add(this.CombatDGV);
            this.Controls.Add(this.TransactionDGV);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ValidEMailBtn);
            this.Controls.Add(this.TopTenUsersBySumBtn);
            this.Controls.Add(this.PlayerDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CombatDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HitDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TopTenUsersBySumBtn;
        private System.Windows.Forms.Button ValidEMailBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.DataGridView TransactionDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMailValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridView CombatDGV;
        private System.Windows.Forms.DataGridView HitDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource hitLogBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource combatBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn combatTypePVPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.Button SaveBtn;

    }
}

