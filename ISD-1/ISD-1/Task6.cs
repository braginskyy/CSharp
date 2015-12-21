using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task6
    {
        public static void TaxiCounter()
        {
            Console.WriteLine("---------------TASK-6---------------");
            string s;
            int km;
            int min;            
            Console.WriteLine("Enter the number of kilometers");
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out km) == false);
            Console.WriteLine("Enter the waiting time in minutes");
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out min) == false);
            if (km < 5)
            {
                Console.WriteLine("The cost of travel {0} grn",20+min);
            }
            else
                Console.WriteLine("The cost of travel {0} grn", 20+(km-5)*3+min);
        }

    }
}
