using System;

namespace Task2sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, sum;
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());

            sum = n1 + n2;
            Console.Write(sum);
        }
    }
}
