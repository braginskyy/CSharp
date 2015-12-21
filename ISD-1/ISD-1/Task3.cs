using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task3
    {
        public static void Vremena_goda ()
        {
            Console.WriteLine("---------------TASK-3---------------");
            Console.WriteLine("Enter the number of the month");
            int m;
            string s;
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out m) == false);
            switch (m)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("On this planet there is no such month");
                    break;
            }    
        }
    }
}
