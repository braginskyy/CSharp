using MyLibraryApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
