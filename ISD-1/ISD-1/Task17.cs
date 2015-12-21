using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task17
    {
        public static void Password() 
        {
            Console.WriteLine("---------------TASK-17---------------");            
            string pass = "root";
            string s;
            do
            {
                Console.WriteLine("Enter the password");
                s = Console.ReadLine();
                if (pass != s)                
                    Console.WriteLine("Wrong password!\n---------------\n");              
                else
                    Console.WriteLine("OK...");
            }
            while (pass != s);
        }
    }
}
