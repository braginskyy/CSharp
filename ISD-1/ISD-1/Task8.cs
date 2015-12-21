using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task8
    {
        public static void Loto()
        {
            Console.WriteLine("---------------TASK-8---------------");
            string s;
            int rate;
            int win;            
            Random r = new Random();  
            Console.WriteLine("Place bet");
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out rate) == false);
            Console.WriteLine("The winning number {0}",win = r.Next(1, 13));
            if(1<=win && win<=5)
            {
                Console.WriteLine("You lose");
            }
            if (6 <= win && win <= 8)
            {
                Console.WriteLine("Your winnings {0}", rate); 
            }
            if (9 <= win && win <= 11)
            {
                Console.WriteLine("Your winnings {0}", rate*2);
            }
            if (win == 12)
            {
                Console.WriteLine("Your winnings {0}", rate * 10); 
            }  
        }
    }
}
