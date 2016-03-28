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
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ISD_13_Data_ContextDataSet1 = new ISD_13._ISD_13_Data_ContextDataSet1();
            this.TopTenUsersBySumBtn = new System.Windows.Forms.Button();
            this.ValidEMailBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.TransactionDGV = new System.Windows.Forms.DataGridView();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new ISD_13._ISD_13_Data_ContextDataSet1TableAdapters.PlayersTableAdapter();
            this.transactionsTableAdapter = new ISD_13._ISD_13_Data_ContextDataSet1TableAdapters.TransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISD_13_Data_ContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
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
            this.PlayerDGV.DataSource = this.playersBindingSource;
            this.PlayerDGV.Location = new System.Drawing.Point(12, 12);
            this.PlayerDGV.Name = "PlayerDGV";
            this.PlayerDGV.Size = new System.Drawing.Size(563, 355);
            this.PlayerDGV.TabIndex = 2;
            this.PlayerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDGV_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this._ISD_13_Data_ContextDataSet1;
            // 
            // _ISD_13_Data_ContextDataSet1
            // 
            this._ISD_13_Data_ContextDataSet1.DataSetName = "_ISD_13_Data_ContextDataSet1";
            this._ISD_13_Data_ContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TopTenUsersBySumBtn
            // 
            this.TopTenUsersBySumBtn.Location = new System.Drawing.Point(12, 373);
            this.TopTenUsersBySumBtn.Name = "TopTenUsersBySumBtn";
            this.TopTenUsersBySumBtn.Size = new System.Drawing.Size(159, 23);
            this.TopTenUsersBySumBtn.TabIndex = 3;
            this.TopTenUsersBySumBtn.Text = "Топ 10 (по платежам)";
            this.TopTenUsersBySumBtn.UseVisualStyleBackColor = true;
            this.TopTenUsersBySumBtn.Click += new System.EventHandler(this.TopTenUsersBySumBtn_Click);
            // 
            // ValidEMailBtn
            // 
            this.ValidEMailBtn.Location = new System.Drawing.Point(191, 373);
            this.ValidEMailBtn.Name = "ValidEMailBtn";
            this.ValidEMailBtn.Size = new System.Drawing.Size(211, 23);
            this.ValidEMailBtn.TabIndex = 4;
            this.ValidEMailBtn.Text = "Выбрать записи с валидным email";
            this.ValidEMailBtn.UseVisualStyleBackColor = true;
            this.ValidEMailBtn.Click += new System.EventHandler(this.ValidEMailBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(423, 373);
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
            this.sumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.TransactionDGV.DataSource = this.transactionsBindingSource;
            this.TransactionDGV.Location = new System.Drawing.Point(595, 12);
            this.TransactionDGV.Name = "TransactionDGV";
            this.TransactionDGV.Size = new System.Drawing.Size(272, 87);
            this.TransactionDGV.TabIndex = 6;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this._ISD_13_Data_ContextDataSet1;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 405);
            this.Controls.Add(this.TransactionDGV);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ValidEMailBtn);
            this.Controls.Add(this.TopTenUsersBySumBtn);
            this.Controls.Add(this.PlayerDGV);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ISD_13_Data_ContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button TopTenUsersBySumBtn;
        private System.Windows.Forms.Button ValidEMailBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.DataGridView TransactionDGV;
        private _ISD_13_Data_ContextDataSet1 _ISD_13_Data_ContextDataSet1;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private _ISD_13_Data_ContextDataSet1TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMailValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private _ISD_13_Data_ContextDataSet1TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}

