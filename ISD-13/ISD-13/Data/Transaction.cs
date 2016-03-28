﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_13.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public int Sum { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
    }
}
