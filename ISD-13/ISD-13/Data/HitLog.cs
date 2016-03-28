using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public enum BodyPart { Head = 1, Body = 2, Legs = 3 };
    public class HitLog
    {
        public int Id { get; set; }
        public int HitValue { get; set; }
        public BodyPart Part { get; set; }
        public int Result { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
    }
}
