using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double theNumb, av = 0;

            for (int i = 0; i < 4; i++)
            {
                theNumb = Convert.ToDouble(Console.ReadLine());
                av += theNumb;
            }

            av /= 4;
            Console.WriteLine(av);
        }
    }
}
