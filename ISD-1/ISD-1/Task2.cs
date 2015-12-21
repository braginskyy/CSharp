using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task2
    {
        public static void Feeding()
        {
            Console.WriteLine("---------------TASK-2---------------");
            Console.WriteLine("Кого кормить?   мяу  /  гав");
            string s = Console.ReadLine();
            detect(s);            
        }
        public static void detect(string s)
        {
            switch (s)
            {
                case "мяу":
                    Console.WriteLine("Покорми кота");
                    break;
                case "гав":
                    Console.WriteLine("Покорми собаку");
                    break;
                default:
                    Console.WriteLine("Неправильная команда");
                    break;
            }
        }
    }
}
