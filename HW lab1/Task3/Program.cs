using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            double res;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            res = x + y;

            

            res += AfterDot(z);
            Console.WriteLine(res);

            res = x;
            res += AfterDot(y);
            Console.WriteLine(res);

        }

        static double AfterDot(double numb)
        {
            while (numb >= 1)
            {
                numb /= 10;
            }

            return numb;
        }
    }
}
