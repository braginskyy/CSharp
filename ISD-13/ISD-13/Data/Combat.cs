using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Combat
    {
        public int Id { get; set; }
        public bool CombatTypePVP { get; set; }
        public string FirstPlayer { get; set; }
        public string SecondPlayer { get; set; }
        public string Winner { get; set; }
        public int Experience { get; set; }
        public List<HitLog> CombatLog { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        public ICollection<Profile> Profiles { get; set; }
        public Combat()
        {
            Profiles = new List<Profile>();
        }
        public virtual Player FirstPlayerNav { get; set; }
        public virtual Player SecondPlayerNav { get; set; }
    }
}
