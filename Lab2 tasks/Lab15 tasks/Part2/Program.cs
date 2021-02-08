using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the real number: ");
            double numb = 0;

            try
            {
                numb = Convert.ToDouble(Console.ReadLine());
                double res;
                res = Math.Sqrt(numb);
                Console.WriteLine("the result is " + res);
            }
            catch (FormatException)
            {
                Console.WriteLine("the number is written in a wrong way!");
            }

            

        }
    }
}
