using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task10
    {
        public static void MultiplicationTable()
        {
            Console.WriteLine("---------------TASK-10---------------");
            Console.WriteLine("Enter the size of the table (1 to 20)");
            int size;
            string s;
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out size) == false || 0 >= size || size >= 21);
            for (int i = 1; i <= size; i++) 
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write("\t"+i*j); 
                }
                Console.WriteLine();
            }
        }
    }
}
