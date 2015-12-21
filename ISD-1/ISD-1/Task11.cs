using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task11
    {
        public static void NumberOfDigits()
        {
            Console.WriteLine("---------------TASK-11---------------");
            Console.WriteLine("Enter the number");
            string s;
            int num;
            int digits = 0;
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out num) == false);
            while (num > 0)            
            {
                digits++;
                num= num /10;
            }
            Console.WriteLine("The number has {0} digits",digits);
        }
    }
}
