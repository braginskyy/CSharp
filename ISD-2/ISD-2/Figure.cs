using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class Figure
    {
        double perimeter = 0;
        double side = 0;
        public Figure(Point a, Point b, Point c)
        {
            Console.WriteLine("Triangle");
            LengthSide(a, b);
            PerimeterCalculator(side);
            LengthSide(b, c);
            PerimeterCalculator(side);
            LengthSide(c, a);
            PerimeterCalculator(side);
            Console.WriteLine(perimeter);

        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            Console.WriteLine("Square");
            LengthSide(a, b);
            PerimeterCalculator(side);
            LengthSide(b, c);
            PerimeterCalculator(side);
            LengthSide(c, d);
            PerimeterCalculator(side);
            LengthSide(d, a);
            PerimeterCalculator(side);
            Console.WriteLine(perimeter);

        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            Console.WriteLine("Pentagon");
            LengthSide(a, b);
            PerimeterCalculator(side);
            LengthSide(b, c);
            PerimeterCalculator(side);
            LengthSide(c, d);
            PerimeterCalculator(side);
            LengthSide(d, e);
            PerimeterCalculator(side);
            LengthSide(e, a);
            PerimeterCalculator(side);
            Console.WriteLine(perimeter);
        }
        double LengthSide(Point a, Point b)
        {
            return side = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        void PerimeterCalculator(double side)
        {
            perimeter += side;
        }
    }
}
