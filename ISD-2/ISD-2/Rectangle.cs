using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Rectangle
    {
        #region
        double side1 = 0;
        double side2 = 0;
        double area = 0;
        double perimeter = 0;
        #endregion

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculaor()
        {
            return area = (side1 * side2);
        }
        public double PerimeterCalculator()
        {
            return perimeter = (2 * side1 + 2 * side2);
        }
        public double Area
        {
            get { return area; }
        }
        public double Perimeter
        {
            get { return perimeter; }
        }
    }
}
