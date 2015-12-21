using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task5
    {
        enum DayEnum { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        public static void DayOfWeek()
        {
            Console.WriteLine("---------------TASK-5---------------");
            Console.WriteLine("Enter the day of week 1 to 7");
            Console.WriteLine((DayEnum)int.Parse(Console.ReadLine()));
        }   
    }
}
