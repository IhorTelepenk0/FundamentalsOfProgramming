using System;

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
            var a = Console.ReadLine();
            string digits = "0123456789";

            if (a.Contains(a))
                Console.WriteLine(a);
            else
                Console.WriteLine("not allowed");
        }

        public static void Exercise2()
        {
            Console.WriteLine("enter the operation (by symbol): ");
            var op = Console.ReadLine();
            Console.WriteLine("enter the first number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            var b = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;

                case "/":
                    Console.WriteLine(a / b);
                    break;

                default:
                    Console.WriteLine("wrong operation");
                    break;
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("enter the binary number: ");
            var bin = Console.ReadLine();
            var hex = Convert.ToInt32(bin, 2).ToString("X");

            Console.WriteLine(hex);
        }

        public static void Exercise4()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
                Console.WriteLine("the number is perfect");
            else
                Console.WriteLine("the number isn't perfect");
        }

        public static void Exercise5()
        {
            Console.WriteLine("enter the number: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.Write(n + "1");
            for (var i = 0; n % 2 == 0; n /= 2)
            {
                Console.Write(" * 2");
            }
            for (var i = 3; i <= n;)
            {
                if (n % i == 0)
                {
                    Console.Write(" * " + i);
                    n /= i;
                }
                else
                {
                    i += 2;
                }
            }
        }
    }
}
