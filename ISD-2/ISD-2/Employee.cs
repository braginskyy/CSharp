using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Employee
    {
        #region
        double[] coefficient = { 1, 1.8, 2.5 };
        string lastname = "";
        string name = "";
        const int rate = 1000;
        const double tax = 0.2;
        double salary = 0;
        int exp = 0;
        string position = "";
        #endregion

        public Employee(string lastname, string name)
        {
            this.lastname = lastname;
            this.name = name;
        }
        public void Salary()
        {
            Console.WriteLine("Enter expirience in year");
            exp = Helper.InputValidationInt();
            Console.WriteLine("Enter the position DIRECTOR / MANAGER / PROMOUTER");
            position = Console.ReadLine().ToUpper();
            if (position == "DIRECTOR")
            {
                salary = rate * coefficient[2] + exp * rate / 10;
                Print(salary);
            }
            else if (position == "MANAGER")
            {
                salary = rate * coefficient[1] + exp * rate / 10;
                Print(salary);
            }
            else if (position == "PROMOUTER")
            {
                salary = rate * coefficient[0] + exp * rate / 10;
                Print(salary);
            }
            else { Console.WriteLine("Position is incorrect"); }
        }
        public void Print(double salary)
        {
            Console.WriteLine("{0}\n{1}\n{2}", lastname, name, position);
            Console.WriteLine("Salary {0:C}", salary - (salary * tax));
            Console.WriteLine("Tax {0:C}", salary * tax);
        }
    }
}
