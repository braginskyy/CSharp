using MyLibraryApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author FirstAuthor { get; set; }
        public Author SecondAuthor { get; set; }
        public bool Status { get; set; }
        public virtual List<Author> Authors { get; set; }
        public Book()
        {
            Authors = new List<Author>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
