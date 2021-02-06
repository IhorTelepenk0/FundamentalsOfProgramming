using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Diam
    {
        public Diam(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 1; j <= size - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
