using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Invoice
    {
        readonly int account = 0;
        readonly string customer = "";
        readonly string provider = "";
        private string article = "";
        private int quantity = 0;
        double price = 11.99;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public void TotalCost()
        {


            Console.WriteLine("№ : {0}\nCustomer : {1}\nProvider : {2}", account, customer, provider);

            Console.WriteLine("You buy {0} in an amount {1}", article, quantity);
            Console.WriteLine("Price {0,28:C}", price * quantity);
            Console.WriteLine("NDS {0,30:C}", price * quantity * 0.2);
            Console.WriteLine("Total price {0,22:C}", price * quantity * 1.2);

        }
    }
}
