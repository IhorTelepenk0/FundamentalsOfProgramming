using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class SumOfOddNumbs : MiddleClass
    {
        public SumOfOddNumbs(int n)
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
