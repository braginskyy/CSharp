using MyLibraryApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.DAL.Entities
{
    public class History
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        public User User { get; set; }
        public string Action { get; set; }
    }
}
