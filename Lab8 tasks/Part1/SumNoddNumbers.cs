using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class SumNoddNumbers
    {
        public SumNoddNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i < n * 2; i += 2)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
