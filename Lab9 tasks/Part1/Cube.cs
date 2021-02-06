using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Cube:Program
    {
        public Cube(int num)
        {
            int res;

            res = Multiplication(num, num) * num;
            Console.WriteLine("the result is " + res);
        }
    }
}
