using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task7
    {
        public static void PrimeNumber() 
        {
            Console.WriteLine("---------------TASK-7---------------");
            string s;
            int n;
            bool prime = true;            
            Console.WriteLine("Enter the number");
            do
            {
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out n) == false);
            for (int i = 2; i < n ; i++)
            {
                if (n % i == 0)
                {
                    prime = false;                    
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Number {0} is prime", n); 
            }
            else
                Console.WriteLine("Number {0} is not prime", n);
        }
    }
}
