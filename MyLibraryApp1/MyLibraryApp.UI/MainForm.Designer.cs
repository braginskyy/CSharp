namespace MyLibraryApp.UI
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.BooksTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReturnBookTxt = new System.Windows.Forms.TextBox();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectedBookTxt = new System.Windows.Forms.TextBox();
            this.TakeBookBtn = new System.Windows.Forms.Button();
            this.SelectedEmailTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AvailableBookCb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondAuthorRb = new System.Windows.Forms.RadioButton();
            this.FirstAuthorRb = new System.Windows.Forms.RadioButton();
            this.NameRb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookSecondAuthor = new System.Windows.Forms.TextBox();
            this.bookFirstAuthor = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.AddNewBookBtn = new System.Windows.Forms.Button();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.AddNewUserBtn = new System.Windows.Forms.Button();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HistorysTab = new System.Windows.Forms.TabPage();
            this.HistoryDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuthorsTab = new System.Windows.Forms.TabPage();
            this.AuthorTxt = new System.Windows.Forms.TextBox();
            this.BookByAuthorDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookByAuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuthorDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainTab.SuspendLayout();
            this.BooksTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.UsersTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.HistorysTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.AuthorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookByAuthorDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookByAuthorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.BooksTab);
            this.MainTab.Controls.Add(this.UsersTab);
            this.MainTab.Controls.Add(this.HistorysTab);
            this.MainTab.Controls.Add(this.AuthorsTab);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(822, 346);
            this.MainTab.TabIndex = 0;
            // 
            // BooksTab
            // 
            this.BooksTab.Controls.Add(this.panel5);
            this.BooksTab.Controls.Add(this.panel2);
            this.BooksTab.Controls.Add(this.panel1);
            this.BooksTab.Controls.Add(this.BookDGV);
            this.BooksTab.Location = new System.Drawing.Point(4, 22);
            this.BooksTab.Name = "BooksTab";
            this.BooksTab.Padding = new System.Windows.Forms.Padding(3);
            this.BooksTab.Size = new System.Drawing.Size(814, 320);
            this.BooksTab.TabIndex = 0;
            this.BooksTab.Text = "Books";
            this.BooksTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(569, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 188);
            this.panel5.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReturnBookTxt);
            this.groupBox2.Controls.Add(this.ReturnBookBtn);
            this.groupBox2.Location = new System.Drawing.Point(15, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // ReturnBookTxt
            // 
            this.ReturnBookTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ReturnBookTxt.Location = new System.Drawing.Point(6, 19);
            this.ReturnBookTxt.Name = "ReturnBookTxt";
            this.ReturnBookTxt.Size = new System.Drawing.Size(190, 20);
            this.ReturnBookTxt.TabIndex = 4;
            this.ReturnBookTxt.Text = "Insert book";
            this.ReturnBookTxt.Click += new System.EventHandler(this.ReturnBookTxt_Click);
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.Location = new System.Drawing.Point(6, 45);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBookBtn.TabIndex = 1;
            this.ReturnBookBtn.Text = "Return book";
            this.ReturnBookBtn.UseVisualStyleBackColor = true;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectedBookTxt);
            this.groupBox1.Controls.Add(this.TakeBookBtn);
            this.groupBox1.Controls.Add(this.SelectedEmailTxt);
            this.groupBox1.Location = new System.Drawing.Point(15, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // SelectedBookTxt
            // 
            this.SelectedBookTxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SelectedBookTxt.Location = new System.Drawing.Point(6, 15);
            this.SelectedBookTxt.Name = "SelectedBookTxt";
            this.SelectedBookTxt.Size = new System.Drawing.Size(190, 20);
            this.SelectedBookTxt.TabIndex = 2;
            this.SelectedBookTxt.Text = "Select book";
            // 
            // TakeBookBtn
            // 
            this.TakeBookBtn.Location = new System.Drawing.Point(6, 67);
            this.TakeBookBtn.Name = "TakeBookBtn";
            this.TakeBookBtn.Size = new System.Drawing.Size(75, 23);
            this.TakeBookBtn.TabIndex = 0;
            this.TakeBookBtn.Text = "Take book";
            this.TakeBookBtn.UseVisualStyleBackColor = true;
            this.TakeBookBtn.Click += new System.EventHandler(this.TakeBookBtn_Click);
            // 
            // SelectedEmailTxt
            // 
            this.SelectedEmailTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SelectedEmailTxt.Location = new System.Drawing.Point(6, 41);
            this.SelectedEmailTxt.Name = "SelectedEmailTxt";
            this.SelectedEmailTxt.Size = new System.Drawing.Size(190, 20);
            this.SelectedEmailTxt.TabIndex = 3;
            this.SelectedEmailTxt.Text = "Insert your Email";
            this.SelectedEmailTxt.Click += new System.EventHandler(this.SelectedEmailTxt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(6, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 28);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.AvailableBookCb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SecondAuthorRb);
            this.panel3.Controls.Add(this.FirstAuthorRb);
            this.panel3.Controls.Add(this.NameRb);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 22);
            this.panel3.TabIndex = 0;
            // 
            // AvailableBookCb
            // 
            this.AvailableBookCb.AutoSize = true;
            this.AvailableBookCb.Location = new System.Drawing.Point(449, 3);
            this.AvailableBookCb.Name = "AvailableBookCb";
            this.AvailableBookCb.Size = new System.Drawing.Size(101, 17);
            this.AvailableBookCb.TabIndex = 5;
            this.AvailableBookCb.Text = "Available books";
            this.AvailableBookCb.UseVisualStyleBackColor = true;
            this.AvailableBookCb.CheckedChanged += new System.EventHandler(this.bookCb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sorted by:";
            // 
            // SecondAuthorRb
            // 
            this.SecondAuthorRb.AutoSize = true;
            this.SecondAuthorRb.Location = new System.Drawing.Point(337, 3);
            this.SecondAuthorRb.Name = "SecondAuthorRb";
            this.SecondAuthorRb.Size = new System.Drawing.Size(95, 17);
            this.SecondAuthorRb.TabIndex = 2;
            this.SecondAuthorRb.TabStop = true;
            this.SecondAuthorRb.Text = "Second author";
            this.SecondAuthorRb.UseVisualStyleBackColor = true;
            this.SecondAuthorRb.CheckedChanged += new System.EventHandler(this.SecondAuthorRb_CheckedChanged);
            // 
            // FirstAuthorRb
            // 
            this.FirstAuthorRb.AutoSize = true;
            this.FirstAuthorRb.Location = new System.Drawing.Point(238, 3);
            this.FirstAuthorRb.Name = "FirstAuthorRb";
            this.FirstAuthorRb.Size = new System.Drawing.Size(77, 17);
            this.FirstAuthorRb.TabIndex = 1;
            this.FirstAuthorRb.TabStop = true;
            this.FirstAuthorRb.Text = "First author";
            this.FirstAuthorRb.UseVisualStyleBackColor = true;
            this.FirstAuthorRb.CheckedChanged += new System.EventHandler(this.FirstAuthorRb_CheckedChanged);
            // 
            // NameRb
            // 
            this.NameRb.AutoSize = true;
            this.NameRb.Location = new System.Drawing.Point(146, 3);
            this.NameRb.Name = "NameRb";
            this.NameRb.Size = new System.Drawing.Size(53, 17);
            this.NameRb.TabIndex = 0;
            this.NameRb.TabStop = true;
            this.NameRb.Text = "Name";
            this.NameRb.UseVisualStyleBackColor = true;
            this.NameRb.CheckedChanged += new System.EventHandler(this.NameRb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bookSecondAuthor);
            this.panel1.Controls.Add(this.bookFirstAuthor);
            this.panel1.Controls.Add(this.bookName);
            this.panel1.Controls.Add(this.AddNewBookBtn);
            this.panel1.Location = new System.Drawing.Point(568, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 116);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author ( second )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Author ( first )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // bookSecondAuthor
            // 
            this.bookSecondAuthor.Location = new System.Drawing.Point(127, 60);
            this.bookSecondAuthor.Name = "bookSecondAuthor";
            this.bookSecondAuthor.Size = new System.Drawing.Size(100, 20);
            this.bookSecondAuthor.TabIndex = 8;
            // 
            // bookFirstAuthor
            // 
            this.bookFirstAuthor.Location = new System.Drawing.Point(127, 34);
            this.bookFirstAuthor.Name = "bookFirstAuthor";
            this.bookFirstAuthor.Size = new System.Drawing.Size(100, 20);
            this.bookFirstAuthor.TabIndex = 6;
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(127, 8);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(100, 20);
            this.bookName.TabIndex = 4;
            // 
            // AddNewBookBtn
            // 
            this.AddNewBookBtn.Location = new System.Drawing.Point(16, 85);
            this.AddNewBookBtn.Name = "AddNewBookBtn";
            this.AddNewBookBtn.Size = new System.Drawing.Size(211, 23);
            this.AddNewBookBtn.TabIndex = 1;
            this.AddNewBookBtn.Text = "Add New Book";
            this.AddNewBookBtn.UseVisualStyleBackColor = true;
            this.AddNewBookBtn.Click += new System.EventHandler(this.AddNewBookBtn_Click);
            // 
            // BookDGV
            // 
            this.BookDGV.AllowUserToAddRows = false;
            this.BookDGV.AllowUserToDeleteRows = false;
            this.BookDGV.AutoGenerateColumns = false;
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.firstAuthorDataGridViewTextBoxColumn,
            this.secondAuthorDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.BookDGV.DataSource = this.bookBindingSource;
            this.BookDGV.Location = new System.Drawing.Point(6, 6);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.ReadOnly = true;
            this.BookDGV.Size = new System.Drawing.Size(556, 275);
            this.BookDGV.TabIndex = 0;
            this.BookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstAuthorDataGridViewTextBoxColumn
            // 
            this.firstAuthorDataGridViewTextBoxColumn.DataPropertyName = "FirstAuthor";
            this.firstAuthorDataGridViewTextBoxColumn.HeaderText = "FirstAuthor";
            this.firstAuthorDataGridViewTextBoxColumn.Name = "firstAuthorDataGridViewTextBoxColumn";
            this.firstAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondAuthorDataGridViewTextBoxColumn
            // 
            this.secondAuthorDataGridViewTextBoxColumn.DataPropertyName = "SecondAuthor";
            this.secondAuthorDataGridViewTextBoxColumn.HeaderText = "SecondAuthor";
            this.secondAuthorDataGridViewTextBoxColumn.Name = "secondAuthorDataGridViewTextBoxColumn";
            this.secondAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(MyLibraryApp.DAL.Entities.Book);
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.panel4);
            this.UsersTab.Controls.Add(this.UserDGV);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(814, 320);
            this.UsersTab.TabIndex = 1;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.userEmail);
            this.panel4.Controls.Add(this.userName);
            this.panel4.Controls.Add(this.AddNewUserBtn);
            this.panel4.Location = new System.Drawing.Point(568, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 103);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(127, 34);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(100, 20);
            this.userEmail.TabIndex = 6;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(127, 8);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 4;
            // 
            // AddNewUserBtn
            // 
            this.AddNewUserBtn.Location = new System.Drawing.Point(16, 72);
            this.AddNewUserBtn.Name = "AddNewUserBtn";
            this.AddNewUserBtn.Size = new System.Drawing.Size(211, 23);
            this.AddNewUserBtn.TabIndex = 1;
            this.AddNewUserBtn.Text = "Add New User";
            this.AddNewUserBtn.UseVisualStyleBackColor = true;
            this.AddNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.AutoGenerateColumns = false;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.UserDGV.DataSource = this.userBindingSource;
            this.UserDGV.Location = new System.Drawing.Point(6, 6);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.Size = new System.Drawing.Size(556, 308);
            this.UserDGV.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MyLibraryApp.DAL.Entities.User);
            // 
            // HistorysTab
            // 
            this.HistorysTab.Controls.Add(this.HistoryDGV);
            this.HistorysTab.Location = new System.Drawing.Point(4, 22);
            this.HistorysTab.Name = "HistorysTab";
            this.HistorysTab.Size = new System.Drawing.Size(814, 320);
            this.HistorysTab.TabIndex = 2;
            this.HistorysTab.Text = "Historys";
            this.HistorysTab.UseVisualStyleBackColor = true;
            // 
            // HistoryDGV
            // 
            this.HistoryDGV.AllowUserToAddRows = false;
            this.HistoryDGV.AllowUserToDeleteRows = false;
            this.HistoryDGV.AutoGenerateColumns = false;
            this.HistoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.bookDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.actionDataGridViewTextBoxColumn});
            this.HistoryDGV.DataSource = this.historyBindingSource;
            this.HistoryDGV.Location = new System.Drawing.Point(3, 3);
            this.HistoryDGV.Name = "HistoryDGV";
            this.HistoryDGV.ReadOnly = true;
            this.HistoryDGV.Size = new System.Drawing.Size(808, 313);
            this.HistoryDGV.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "Book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "Book";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            this.bookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn1.HeaderText = "User";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(MyLibraryApp.DAL.Entities.History);
            // 
            // AuthorsTab
            // 
            this.AuthorsTab.Controls.Add(this.AuthorTxt);
            this.AuthorsTab.Controls.Add(this.BookByAuthorDGV);
            this.AuthorsTab.Controls.Add(this.AuthorDGV);
            this.AuthorsTab.Location = new System.Drawing.Point(4, 22);
            this.AuthorsTab.Name = "AuthorsTab";
            this.AuthorsTab.Size = new System.Drawing.Size(814, 320);
            this.AuthorsTab.TabIndex = 3;
            this.AuthorsTab.Text = "Authors";
            this.AuthorsTab.UseVisualStyleBackColor = true;
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.Location = new System.Drawing.Point(3, 296);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.Size = new System.Drawing.Size(808, 20);
            this.AuthorTxt.TabIndex = 7;
            // 
            // BookByAuthorDGV
            // 
            this.BookByAuthorDGV.AllowUserToAddRows = false;
            this.BookByAuthorDGV.AllowUserToDeleteRows = false;
            this.BookByAuthorDGV.AutoGenerateColumns = false;
            this.BookByAuthorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookByAuthorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookByAuthorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn3});
            this.BookByAuthorDGV.DataSource = this.bookByAuthorBindingSource;
            this.BookByAuthorDGV.Location = new System.Drawing.Point(399, 3);
            this.BookByAuthorDGV.Name = "BookByAuthorDGV";
            this.BookByAuthorDGV.ReadOnly = true;
            this.BookByAuthorDGV.Size = new System.Drawing.Size(412, 287);
            this.BookByAuthorDGV.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bookByAuthorBindingSource
            // 
            this.bookByAuthorBindingSource.DataSource = typeof(MyLibraryApp.DAL.Entities.Book);
            // 
            // AuthorDGV
            // 
            this.AuthorDGV.AllowUserToAddRows = false;
            this.AuthorDGV.AllowUserToDeleteRows = false;
            this.AuthorDGV.AutoGenerateColumns = false;
            this.AuthorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuthorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn2});
            this.AuthorDGV.DataSource = this.authorBindingSource;
            this.AuthorDGV.Location = new System.Drawing.Point(3, 3);
            this.AuthorDGV.Name = "AuthorDGV";
            this.AuthorDGV.ReadOnly = true;
            this.AuthorDGV.Size = new System.Drawing.Size(390, 287);
            this.AuthorDGV.TabIndex = 5;
            this.AuthorDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuthorDGV_CellClick);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(MyLibraryApp.DAL.Entities.Author);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.authorBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 362);
            this.Controls.Add(this.MainTab);
            this.MaximumSize = new System.Drawing.Size(862, 401);
            this.MinimumSize = new System.Drawing.Size(862, 401);
            this.Name = "MainForm";
            this.Text = "LibraryApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.BooksTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.UsersTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.HistorysTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.AuthorsTab.ResumeLayout(false);
            this.AuthorsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookByAuthorDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookByAuthorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage BooksTab;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.TabPage HistorysTab;
        private System.Windows.Forms.TabPage AuthorsTab;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.DataGridView HistoryDGV;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView AuthorDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button AddNewBookBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.TextBox bookSecondAuthor;
        private System.Windows.Forms.TextBox bookFirstAuthor;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton SecondAuthorRb;
        private System.Windows.Forms.RadioButton FirstAuthorRb;
        private System.Windows.Forms.RadioButton NameRb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button AddNewUserBtn;
        private System.Windows.Forms.CheckBox AvailableBookCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ReturnBookBtn;
        private System.Windows.Forms.Button TakeBookBtn;
        private System.Windows.Forms.TextBox SelectedBookTxt;
        private System.Windows.Forms.TextBox SelectedEmailTxt;
        private System.Windows.Forms.TextBox ReturnBookTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView BookByAuthorDGV;
        private System.Windows.Forms.TextBox AuthorTxt;
        private System.Windows.Forms.BindingSource bookByAuthorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
    }
}

