using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_1
{
    public static class Task9
    {
        public static void CurrencyEexchange()
        {
            Console.WriteLine("---------------TASK-9---------------");
            string s;
            float money;
            float USD= 24.6f;
            float EUR= 25.8f;
            Random r = new Random();
            Console.WriteLine("Enter the amount");
            do
            {
                s = Console.ReadLine();
            }
            while (float.TryParse(s, out money) == false);
            Console.WriteLine("select currency    USD  /  EUR  /  UAH");
            s = Console.ReadLine();
            switch(s.ToUpper())
            {
                case "USD":
                    Console.WriteLine("{0} USD  /  {1} EUR  /  {2} UAH", money, money * (USD / EUR), money * USD);
                    break;
                case "EUR":
                    Console.WriteLine("{0} EUR  /  {1} USD  /  {2} UAH", money, money * (EUR / USD), money * EUR);
                    break;
                case "UAH":
                    Console.WriteLine("{0} UAH  /  {1} USD  /  {2} EUR", money, money / USD, money / EUR);
                    break;
                default:
                    Console.WriteLine("We do not have such currency");
                    break;
            }
        }
    }
}
