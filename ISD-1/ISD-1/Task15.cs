using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task15
    {
        public static void RandomAverage() 
        {
            Console.WriteLine("---------------TASK-15---------------");
            Random r = new Random();
            int ave=0;
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = r.Next();
                ave += num[i];
                Console.WriteLine("-----------{0}",num[i]);
            }            
            Console.WriteLine("Average {0}", ave / num.Length);
        }
    }
}
