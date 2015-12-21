using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
     public static class Task14
    {
        public static void Average()
        {
            Console.WriteLine("---------------TASK-14---------------");
            Console.WriteLine("Enter the 5 integers");
            string s;
            float ave = 0f;
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                do
                {
                    s = Console.ReadLine();                    
                }
                while (int.TryParse(s, out num[i]) == false);
                ave += num[i];
            }           
            Console.WriteLine("Average {0}",ave/num.Length);
        }        
    }
}
