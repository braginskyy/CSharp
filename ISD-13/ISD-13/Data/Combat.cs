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
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public Player Winner { get; set; }
        public int Experience { get; set; }
        public List<HitLog> CombatLog { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
    }
}
