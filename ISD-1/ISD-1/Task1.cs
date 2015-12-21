using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task1
    {
        public static void Max_number()
        {
            Console.WriteLine("---------------TASK-1---------------");
            Console.WriteLine("Enter the first number");
            string s;
            int m;
            int n;
            // Проверяем, является ли введенная строка числом  из диапазона Int.
            do
            {               
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out m) == false);
            Console.WriteLine("enter the second number");
            do
            {                
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out n) == false);
            //Выводим большее число
            if (m > n)
            {
                Console.WriteLine("Increasing the number of {0}", m);
            }
            else
                Console.WriteLine("Increasing the number of {0}", n);            
        }
    }
}
