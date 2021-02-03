using System;

namespace task5_multOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, mult;
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());

            mult = n1 * n2 * n3;
            Console.Write(mult);
        }
    }
}
