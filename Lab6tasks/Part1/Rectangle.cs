using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Rectangle
    {
        private double _a;
        private double _b;

         public Rectangle(double side1, double side2)
        {
            _a = side1;
            _b = side2;
        }

        public double Area()
        {
            return _a * _b;
        }
    }
}
