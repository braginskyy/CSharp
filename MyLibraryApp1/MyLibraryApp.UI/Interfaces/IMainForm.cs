using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.UI.Interfaces
{
    public interface IMainForm
    {
        event EventHandler LoadAllTables;
        event EventHandler AddNewBook;
        event EventHandler AddNewUser;
        event EventHandler TakeBook;
        event EventHandler ReturnBook;
        event EventHandler LoadBookByAuthor;

        object AuthorBindingSource { set; }
        object BookBindingSource { set; }
        object HistoryBindingSource { set; }
        object UserBindingSource { set; }
        object BookByAuthorBindingSource { set; }

        string BookName { get; }
        string FirstAuthor { get; }
        string SecondAuthor { get; }
        string UserName { get; }
        string UserEmail { get; }
        string SelectEmail { get; }
        string SelectBook { get; }
        string ReturnSelectBook { get; }
        string SelectAuthor { get; }

        bool AvailableBooksStatus { get; }
        bool SortByName { get; }
        bool SortByFirstAuthor { get; }
        bool SortBySecondAuthor { get; }

    }
}
