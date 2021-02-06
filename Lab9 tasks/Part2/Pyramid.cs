using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Pyramid : MiddleClass
    {
        public Pyramid(int size)
        {
            for (int i = 0; i <= size; i++)
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
