using MyLibraryApp.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp.UI
{
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler LoadAllTables;
        public event EventHandler AddNewBook;
        public event EventHandler AddNewUser;
        public event EventHandler TakeBook;
        public event EventHandler ReturnBook;
        public event EventHandler LoadBookByAuthor;

        public MainPresenter presenter;        
        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }


        public object AuthorBindingSource
        {
            set { authorBindingSource.DataSource = value; }
        }
        public object BookBindingSource
        {
            set { bookBindingSource.DataSource = value; }
        }
        public object HistoryBindingSource
        {
            set { historyBindingSource.DataSource = value; }
        }
        public object UserBindingSource
        {
            set { userBindingSource.DataSource = value; }
        }
        public object BookByAuthorBindingSource 
        {
            set { bookByAuthorBindingSource.DataSource = value; } 
        } 

        public string BookName
        {
            get { return bookName.Text; }
        }
        public string FirstAuthor
        {
            get { return bookFirstAuthor.Text; }
        }
        public string SecondAuthor
        {
            get { return bookSecondAuthor.Text; }
        }
        public string UserName
        {
            get { return userName.Text; }
        }
        public string UserEmail
        {
            get { return userEmail.Text; }
        }
        public string SelectEmail 
        {
            get { return SelectedEmailTxt.Text; }
        }
        public string SelectBook 
        {
            get { return SelectedBookTxt.Text; } 
        }
        public string ReturnSelectBook 
        {
            get { return ReturnBookTxt.Text; } 
        }
        public string SelectAuthor
        {
            get { return AuthorTxt.Text; }
        }
        public bool SortByName
        {
            get { return NameRb.Checked; }
        }
        public bool SortByFirstAuthor
        {
            get { return FirstAuthorRb.Checked; }
        }
        public bool SortBySecondAuthor
        {
            get { return SecondAuthorRb.Checked; }
        }
        public bool AvailableBooksStatus
        {
            get { return AvailableBookCb.Checked; }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            BookDGV.DataSource = bookBindingSource;            
            AuthorDGV.DataSource = authorBindingSource;
            HistoryDGV.DataSource = historyBindingSource;
            UserDGV.DataSource = userBindingSource;
            BookByAuthorDGV.DataSource = bookByAuthorBindingSource;
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }

        }

        private void AddNewBookBtn_Click(object sender, EventArgs e)
        {
            if (AddNewBook != null) { AddNewBook(this, EventArgs.Empty); }
            bookName.Text = string.Empty;
            bookFirstAuthor.Text = string.Empty;
            bookSecondAuthor.Text = string.Empty;
        }

        private void NameRb_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            if (AddNewUser != null) { AddNewUser(this, EventArgs.Empty); }
            userName.Text = string.Empty;
            userEmail.Text = string.Empty;
        }
        
        private void BookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedBookTxt.Text = (string)BookDGV[1, BookDGV.CurrentCellAddress.Y].Value;
            SelectedBookTxt.BackColor = Color.Yellow;
        }

        private void SelectedEmailTxt_Click(object sender, EventArgs e)
        {
            SelectedEmailTxt.Text = string.Empty;
        }

        private void TakeBookBtn_Click(object sender, EventArgs e)
        {
            if (SelectedEmailTxt.Text != "Insert your Email" && SelectedEmailTxt.Text != "" && SelectedBookTxt.Text != "Select book")
            {
                if (TakeBook != null) { TakeBook(this, EventArgs.Empty); }
            }
            SelectedBookTxt.Text = string.Empty;
            SelectedEmailTxt.Text = string.Empty;
        }

        private void ReturnBookTxt_Click(object sender, EventArgs e)
        {
            ReturnBookTxt.Text = string.Empty;
        }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            if (ReturnBookTxt.Text != "Insert book")
            {
                if (ReturnBook != null) { ReturnBook(this, EventArgs.Empty); }
            }
            ReturnBookTxt.Text = string.Empty;
        }

        private void AuthorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AuthorTxt.Text = (string)AuthorDGV[1, AuthorDGV.CurrentCellAddress.Y].Value;
            AuthorTxt.BackColor = Color.Yellow;
            if (LoadBookByAuthor != null) { LoadBookByAuthor(this, EventArgs.Empty); }
        }

        private void FirstAuthorRb_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void bookCb_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

        private void SecondAuthorRb_CheckedChanged(object sender, EventArgs e)
        {
            if (LoadAllTables != null) { LoadAllTables(this, EventArgs.Empty); }
        }

    }
}
