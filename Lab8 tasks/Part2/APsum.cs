using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class APsum
    {
        public APsum(int first, int differ, int n)
        {
            Console.WriteLine("Sum: " + (2 * first + differ * (n - 1)) * n / 2);
        }
    }
}
