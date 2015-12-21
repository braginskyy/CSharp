using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task16
    {
        public static void Farm()
        {
            Console.WriteLine("---------------TASK-16---------------");
            Console.WriteLine("\n\trabbit \tgoose\n");
            int j;
            for (int i = 0; i <= 16; i++)
            {
                j = (64 - i * 4) / 2;
                Console.WriteLine("\t{0}\t{1}",i,j);
            }
        }
    }
}
