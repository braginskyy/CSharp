using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("|Braginskyy Oleg Borisovich|");
            Console.WriteLine("+--------------------------+");

            // (-------------------------------Task 1------------------------------)

            Address adr = new Address();
            Console.WriteLine("Enter index");
            adr.index = Helper.InputValidationInt();
            Console.WriteLine("Enter Coutry");
            adr.country = Console.ReadLine();
            Console.WriteLine("Enter City");
            adr.city = Console.ReadLine();
            Console.WriteLine("Enter Street");
            adr.street = Console.ReadLine();
            Console.WriteLine("Enter House");
            adr.house = Helper.InputValidationInt();
            Console.WriteLine("Enter Apartment");
            adr.apartment = Helper.InputValidationInt();
            adr.PrintInfo();

            // (-------------------------------Task 2------------------------------)

            Console.WriteLine("Enter the first and second side");
            Rectangle rect = new Rectangle(Helper.InputValidationDouble(), Helper.InputValidationDouble());
            rect.AreaCalculaor();
            rect.PerimeterCalculator();
            Console.WriteLine("{0}\n{1}", rect.Area, rect.Perimeter);

            // (-------------------------------Task 3------------------------------)

            Console.WriteLine("Enter the title, the author and the content of the book");
            Book book = new Book();
            book.Title = Console.ReadLine();
            book.Author = Console.ReadLine();
            book.Content = Console.ReadLine();
            Title.Show();
            Author.Show();
            Content.Show();

            // (-------------------------------Task 4------------------------------)

            Console.WriteLine("Enter X and Y of point A");
            Point a = new Point(Helper.InputValidationInt(), Helper.InputValidationInt(), "a");
            Console.WriteLine("Enter X and Y of point B");
            Point b = new Point(Helper.InputValidationInt(), Helper.InputValidationInt(), "b");
            Console.WriteLine("Enter X and Y of point C");
            Point c = new Point(Helper.InputValidationInt(), Helper.InputValidationInt(), "c");
            Console.WriteLine("Enter X and Y of point D");
            Point d = new Point(Helper.InputValidationInt(), Helper.InputValidationInt(), "d");
            Console.WriteLine("Enter X and Y of point E");
            Point e = new Point(Helper.InputValidationInt(), Helper.InputValidationInt(), "e");

            new Figure(a, b, c);
            new Figure(a, b, c, d);
            new Figure(a, b, c, d, e);

            // (-------------------------------Task 5------------------------------)

            Console.WriteLine("Enter Login\nName\nLastname\nAge");
            User u = new User(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Helper.InputValidationInt());
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", u.Login, u.Name, u.Lastname, u.Age, u.Date);


            // (-------------------------------Task 6------------------------------)

            Console.WriteLine("Enter the exchange rate of USD / EUR / RUB ");
            Converter conv = new Converter(Helper.InputValidationDouble(), Helper.InputValidationDouble(), Helper.InputValidationDouble());
            Console.WriteLine("How much you want to convert");
            conv.money = Helper.InputValidationDouble();
            Console.WriteLine("What is your currency? USD / EUR / RUB / UAH ");
            conv.curr1 = Console.ReadLine().ToUpper();
            Console.WriteLine("What currency you need? USD / EUR / RUB / UAH ");
            conv.curr2 = Console.ReadLine().ToUpper();
            conv.GoConvert();


            //(-------------------------------Task 7------------------------------)

            Console.WriteLine("Enter Lastname and Name");
            Employee emp = new Employee(Console.ReadLine(), Console.ReadLine());
            emp.Salary();


            //(-------------------------------Task 8------------------------------)

            Console.WriteLine("Enter account/custome/provider");
            Invoice inv = new Invoice(Helper.InputValidationInt(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("What do you want to buy?");
            inv.Article = Console.ReadLine();
            Console.WriteLine("Enter quantity");
            inv.Quantity = Helper.InputValidationInt();
            inv.TotalCost();
            Console.ReadKey();
        }
    }
}
