namespace ISD_10
{
    partial class Score
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
            this.InsertNameTxt = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.resultDataGtid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGtid)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertNameTxt
            // 
            this.InsertNameTxt.Location = new System.Drawing.Point(12, 229);
            this.InsertNameTxt.Name = "InsertNameTxt";
            this.InsertNameTxt.Size = new System.Drawing.Size(468, 20);
            this.InsertNameTxt.TabIndex = 0;
            this.InsertNameTxt.Text = "Введите ваше имя";
            this.InsertNameTxt.Click += new System.EventHandler(this.InsertNameTxt_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(497, 227);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "В бой";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // resultDataGtid
            // 
            this.resultDataGtid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGtid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.resultDataGtid.Location = new System.Drawing.Point(12, 22);
            this.resultDataGtid.Name = "resultDataGtid";
            this.resultDataGtid.Size = new System.Drawing.Size(559, 190);
            this.resultDataGtid.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hp";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.resultDataGtid);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.InsertNameTxt);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Rating";
            this.Text = "Rating";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGtid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InsertNameTxt;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.DataGridView resultDataGtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}