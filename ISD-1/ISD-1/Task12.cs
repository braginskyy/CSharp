using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{ 
    public static class Task12
    {
        public static void GuessTheTumber()
        {
            Console.WriteLine("---------------TASK-12---------------");
            Random r = new Random();
            int num = r.Next(1, 147);
            string s;
            int i=0;
            Console.WriteLine("Guess the number between 1 and 146");            
            do
            { 
                if (i < num && i !=0)
                    Console.WriteLine("more");
                if (i > num && i !=0)
                    Console.WriteLine("less");
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out i) == false||i != num);
            Console.WriteLine("You win!");
        }
    }
}
