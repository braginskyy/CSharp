using MyLibraryApp.DAL.Entities;
using MyLibraryApp.DAL.Repository;
using MyLibraryApp.DAL.Repository.Interfaces;
using MyLibraryApp.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.UI
{
    public class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IProxy proxy;
        private List<Author> authorList;
        private List<Book>bookList;
        private List<History> historyList;
        private List<User> userList;
        private List<Book> bookListByAuthor;

        public MainPresenter(IMainForm view)
        {
            this.view = view;
            this.proxy = new Proxy();
            view.LoadAllTables += view_LoadAllTables;
            view.AddNewBook += view_AddNewBook;
            view.AddNewUser += view_AddNewUser;
            view.TakeBook += view_TakeBook;
            view.ReturnBook += view_ReturnBook;
            view.LoadBookByAuthor += view_LoadBookByAuthor;
        }

        void view_LoadBookByAuthor(object sender, EventArgs e)
        {
            bookListByAuthor = proxy.Book.FindBooksByAuthor(view.SelectAuthor).ToList();
            view.BookByAuthorBindingSource = bookListByAuthor;
        }
        void view_ReturnBook(object sender, EventArgs e)
        {
            if (proxy.Book.FindBookByName(view.ReturnSelectBook) != null)
            {
                if (proxy.Book.FindBookByName(view.ReturnSelectBook).Status == false)
                {
                    var book = proxy.Book.FindBookByName(view.ReturnSelectBook);
                    book.Status = true;
                    proxy.Book.Update(book);
                    proxy.History.Create(new History { Book = book, Date = DateTime.Now, User = proxy.History.FindLastHistoryByBook(book).User, Action = "return" });
                    proxy.Save();
                    LoadBookTable();
                    LoadHistoryTable();
                }
            }
        }
        void view_TakeBook(object sender, EventArgs e)
        {
            if (proxy.Book.FindBookByName(view.SelectBook).Status == true)
            {
                if (proxy.User.FindUserByEmail(view.SelectEmail) != null)
                {
                    var book = proxy.Book.FindBookByName(view.SelectBook);
                    book.Status = false;
                    proxy.Book.Update(book);

                    proxy.History.Create(new History { Book = book, Date = DateTime.Now, User = proxy.User.FindUserByEmail(view.SelectEmail), Action = "take" });
                    proxy.Save();
                    LoadBookTable();
                    LoadHistoryTable();
                }
            }
        }
        void view_AddNewUser(object sender, EventArgs e)
        {
            if ((view.UserEmail != string.Empty) && (view.UserName != string.Empty))
            {
                proxy.User.Create(new User { Name = view.UserName, Email = view.UserEmail });
                proxy.Save();
                LoadUserTable();
            }
        }
        void view_LoadAllTables(object sender, EventArgs e)
        {
            LoadUserTable();
            LoadBookTable();
            LoadAuthorTable();
            LoadHistoryTable();
        }
        void view_AddNewBook(object sender, EventArgs e)
        {
            if ((view.BookName != string.Empty) && (view.FirstAuthor != string.Empty))
            {
                if (proxy.Author.FindAuthorByName(view.FirstAuthor) == null)
                {
                    proxy.Author.Create(new Author() { Name = view.FirstAuthor });
                }
                if (proxy.Author.FindAuthorByName(view.SecondAuthor) == null && view.SecondAuthor!= string.Empty)
                {
                    proxy.Author.Create(new Author() { Name = view.SecondAuthor });
                }
                proxy.Save();

                proxy.Book.Create(new Book()
                {
                    Name = view.BookName,
                    FirstAuthor = proxy.Author.FindAuthorByName(view.FirstAuthor),
                    SecondAuthor = proxy.Author.FindAuthorByName(view.SecondAuthor),
                    Status = true
                });
                proxy.Save();
                LoadAuthorTable();
                LoadBookTable();
            }
        }
        private void LoadBookTable()
        {            
            bookList = proxy.Book.GetAll().ToList();            
            if (view.AvailableBooksStatus)
            {
                bookList = proxy.Book.FindAvailableBook().ToList();
            }
            if (view.SortByName)
            {
                bookList = bookList.OrderBy(p => p.Name).ToList();
            }
            if (view.SortByFirstAuthor)
            {
                bookList = bookList.OrderBy(p => p.FirstAuthor.Name).ToList();
            }
            if (view.SortBySecondAuthor)
            {
                bookList = bookList.Where(p => p.SecondAuthor != null).OrderBy(p => p.SecondAuthor.Name)
                    .Union(bookList.Where(p => p.SecondAuthor == null)).ToList();                   
            }
            view.BookBindingSource = bookList;
        }
        private void LoadAuthorTable()
        {
            authorList = proxy.Author.GetAll().ToList();
            view.AuthorBindingSource = authorList;
        }
        private void LoadHistoryTable()
        {
            historyList = proxy.History.GetAll().ToList();
            view.HistoryBindingSource = historyList;
        }
        private void LoadUserTable()
        {
            userList = proxy.User.GetAll().ToList();
            view.UserBindingSource = userList;
        }
    }
}
