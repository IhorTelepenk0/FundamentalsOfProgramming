using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Floyd : MiddleClass
    {
        public Floyd(int n)
        {
            var v = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(v + " ");
                    v++;
                }

                Console.WriteLine();
            }
        }
    }
}
