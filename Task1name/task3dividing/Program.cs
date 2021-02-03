using System;

namespace task3dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, dev;
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());

            dev = n1 / n2;
            Console.Write(dev);
        }
    }
}
