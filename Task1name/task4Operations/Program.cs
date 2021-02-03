using System;

namespace task4Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;

            res = -1 + (4 * 6);
            Console.WriteLine(res);

            res = (35 + 5) % 7;
            Console.WriteLine(res);

            res = 14 + ((-4.0f) * 6.0f / 11.0f);
            Console.WriteLine(Math.Round(res,2));

            res = 2 + 15.0f / 6 * 1 - (7 % 2);
            Console.WriteLine(res);
            /*n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());

            mult = n1 * n2 * n3;
            Console.Write(mult);*/
        }
    }
}
