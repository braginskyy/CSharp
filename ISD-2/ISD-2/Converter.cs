using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Converter
    {
        #region
        double usd = 0;
        double eur = 0;
        double rub = 0;
        public double money = 0;
        public string curr1 = "";
        public string curr2 = "";
        #endregion

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void GoConvert()
        {
            if (curr2 == "USD") { ConvertToUSD(money, curr1); }
            else if (curr2 == "EUR") { ConvertToEUR(money, curr1); }
            else if (curr2 == "RUB") { ConvertToRUB(money, curr1); }
            else if (curr2 == "UAH") { ConvertToUAH(money, curr1); }
            else { Console.WriteLine("Incorrectly specified currency"); }
        }
        public void ConvertToUSD(double money, string curr1)
        {
            if (curr1 == "EUR") { Console.WriteLine("{0} EUR = {1} USD", money, money * (eur / usd)); }
            else if (curr1 == "RUB") { Console.WriteLine("{0} RUB = {1} USD", money, money * (rub / usd)); }
            else if (curr1 == "UAH") { Console.WriteLine("{0} UAH = {1} USD", money, money / usd); }
            else if (curr1 == "USD") { Console.WriteLine("{0} USD = {1} USD", money, money); }
            else { Console.WriteLine("Incorrectly specified currency"); }
        }
        public void ConvertToEUR(double money, string curr1)
        {
            if (curr1 == "EUR") { Console.WriteLine("{0} EUR = {1} EUR", money, money); }
            else if (curr1 == "RUB") { Console.WriteLine("{0} RUB = {1} EUR", money, money * (rub / eur)); }
            else if (curr1 == "UAH") { Console.WriteLine("{0} UAH = {1} EUR", money, money / eur); }
            else if (curr1 == "USD") { Console.WriteLine("{0} USD = {1} EUR", money, money * (usd / eur)); }
            else { Console.WriteLine("Incorrectly specified currency"); }
        }
        public void ConvertToRUB(double money, string curr1)
        {
            if (curr1 == "EUR") { Console.WriteLine("{0} EUR = {1} RUB", money, money * eur / rub); }
            else if (curr1 == "RUB") { Console.WriteLine("{0} RUB = {1} RUB", money, money * money); }
            else if (curr1 == "UAH") { Console.WriteLine("{0} UAH = {1} RUB", money, money / rub); }
            else if (curr1 == "USD") { Console.WriteLine("{0} USD = {1} RUB", money, money * (usd / rub)); }
            else { Console.WriteLine("Incorrectly specified currency"); }
        }
        public void ConvertToUAH(double money, string curr1)
        {
            if (curr1 == "EUR") { Console.WriteLine("{0} EUR = {1} UAH", money, money * eur); }
            else if (curr1 == "RUB") { Console.WriteLine("{0} RUB = {1} UAH", money, money * rub); }
            else if (curr1 == "UAH") { Console.WriteLine("{0} UAH = {1} UAH", money, money); }
            else if (curr1 == "USD") { Console.WriteLine("{0} USD = {1} UAH", money, money * usd); }
            else { Console.WriteLine("Incorrectly specified currency"); }
        }
    }
}
