using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Address
    {
        #region
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
        #endregion

        public void PrintInfo()
        {
            Console.WriteLine("Index{0,25}\nCountry{1,23}\nCity{2,26}\nStreet{3,24}\nHouse{4,25}\nApartment{5,21}",
                index, country, city, street, house, apartment);
        }
    }
}
