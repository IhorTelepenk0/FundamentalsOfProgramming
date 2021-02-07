using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Converter
    {
        public static void Convert(int num)
        {
            Console.WriteLine(num / 100);
        }

        public static void Convert(double num)
        {
            Console.WriteLine(num / 100.0f);
        }

        public static void Convert(float num)
        {
            Console.WriteLine(num / 100.0f);
        }
    }
}
