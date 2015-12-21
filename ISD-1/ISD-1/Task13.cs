using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task13
    {
        public static void Square ()
        {
            Console.WriteLine("---------------TASK-13---------------");
            Console.WriteLine("Enter the number");
            string s;
            int num;
            int x = 1;
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out num) == false);
            while (x * x < num)
            {
                Console.WriteLine(x * x);
                x++;
            }  
        }
    }
}
