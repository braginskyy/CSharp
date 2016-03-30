using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Profile
    {
        [Key]
        [ForeignKey("Player")]
        public int Id { get; set; }
        public Player Player { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        public List<Transaction> Transactions { get; set; }
        public ICollection<Combat> Combats { get; set; }
        public Profile()
        {
            Combats = new List<Combat>();
        }
    }
}
