using System;
using System.Dynamic;
using System.Linq;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for testing
        }

        public static void Exercise1()
        {
            var str = Console.ReadLine();
            int count = str.Count(f => f == ' ');
        }

        public static void Exercise2()
        {
            int a, b;
            Console.WriteLine("enter the numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int bubble;
            bubble = a;
            a = b;
            b = bubble;
        }

        public static void Exercise3()
        {
            int n, i, flag = 0;
            Console.Write("enter the number: ");
            n = int.Parse(Console.ReadLine());
            
            for (i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("the number isn't prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("the  umber is prime");
        }

        public static void Exercise4()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine("the sum of digits is: " + sum);
        }

        public static void Exercise5()
        {
            int fact = 1, number;
            Console.Write("enter the number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("the fectorial is: " + fact);
        }

    }
}
