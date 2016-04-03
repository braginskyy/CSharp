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
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ValidEmailCB = new System.Windows.Forms.CheckBox();
            this.TopTenUsersBySumCB = new System.Windows.Forms.CheckBox();
            this.PlayerDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailValidDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hitLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(605, 272);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ValidEmailCB
            // 
            this.ValidEmailCB.AutoSize = true;
            this.ValidEmailCB.Location = new System.Drawing.Point(12, 272);
            this.ValidEmailCB.Name = "ValidEmailCB";
            this.ValidEmailCB.Size = new System.Drawing.Size(77, 17);
            this.ValidEmailCB.TabIndex = 14;
            this.ValidEmailCB.Text = "Valid Email";
            this.ValidEmailCB.UseVisualStyleBackColor = true;
            this.ValidEmailCB.CheckedChanged += new System.EventHandler(this.ValidEmailCB_CheckedChanged);
            // 
            // TopTenUsersBySumCB
            // 
            this.TopTenUsersBySumCB.AutoSize = true;
            this.TopTenUsersBySumCB.Location = new System.Drawing.Point(12, 295);
            this.TopTenUsersBySumCB.Name = "TopTenUsersBySumCB";
            this.TopTenUsersBySumCB.Size = new System.Drawing.Size(98, 17);
            this.TopTenUsersBySumCB.TabIndex = 15;
            this.TopTenUsersBySumCB.Text = "Top 10 by Sum";
            this.TopTenUsersBySumCB.UseVisualStyleBackColor = true;
            this.TopTenUsersBySumCB.CheckedChanged += new System.EventHandler(this.TopTenUsersBySumCB_CheckedChanged);
            // 
            // PlayerDGV
            // 
            this.PlayerDGV.AutoGenerateColumns = false;
            this.PlayerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.loginDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.eMailDataGridViewTextBoxColumn1,
            this.eMailValidDataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.PlayerDGV.DataSource = this.playerBindingSource;
            this.PlayerDGV.Location = new System.Drawing.Point(12, 38);
            this.PlayerDGV.Name = "PlayerDGV";
            this.PlayerDGV.Size = new System.Drawing.Size(668, 228);
            this.PlayerDGV.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // eMailDataGridViewTextBoxColumn1
            // 
            this.eMailDataGridViewTextBoxColumn1.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn1.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn1.Name = "eMailDataGridViewTextBoxColumn1";
            // 
            // eMailValidDataGridViewCheckBoxColumn1
            // 
            this.eMailValidDataGridViewCheckBoxColumn1.DataPropertyName = "EMailValid";
            this.eMailValidDataGridViewCheckBoxColumn1.HeaderText = "EMailValid";
            this.eMailValidDataGridViewCheckBoxColumn1.Name = "eMailValidDataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(ISD_13.Data.Player);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(ISD_13.Data.Transaction);
            // 
            // combatBindingSource
            // 
            this.combatBindingSource.DataSource = typeof(ISD_13.Data.Combat);
            // 
            // hitLogBindingSource
            // 
            this.hitLogBindingSource.DataSource = typeof(ISD_13.Data.HitLog);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 317);
            this.Controls.Add(this.PlayerDGV);
            this.Controls.Add(this.TopTenUsersBySumCB);
            this.Controls.Add(this.ValidEmailCB);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource hitLogBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource combatBindingSource;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox ValidEmailCB;
        private System.Windows.Forms.CheckBox TopTenUsersBySumCB;
        private System.Windows.Forms.DataGridView PlayerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eMailValidDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}

