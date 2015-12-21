using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{    
    public static class Task4
    {        
        public static void GoodOrBad()
        {
            Console.WriteLine("---------------TASK-4---------------");
            Console.WriteLine("Enter 0 or 1");
            Console.WriteLine(0==int.Parse(Console.ReadLine())?"Bad":"Good");           
        }
    }
}
