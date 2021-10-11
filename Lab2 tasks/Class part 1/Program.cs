using System;

namespace Class_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for testing
        }

        public static void Exercise1()
        {
            double n1, n2, res;
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "adding")
                res = n1 + n2;
            else
            {
                if (operation == "subtracting")
                    res = n1 - n2;
                else
                {
                    if (operation == "multiplying")
                        res = n1 * n2;
                    else
                    {
                        if (operation == "dividing")
                            res = n1 / n2;
                        else
                        {
                            Console.WriteLine("wrong operation");
                            res = 0;
                        }
                    }
                }
            }

            Console.WriteLine(res);
        }

        public static void Exercise2()
        {
            var a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} x {i} = {a * i}");
            }
        }

        public static bool Exercise3()
        {
            Console.WriteLine("Enter the first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a < 0 && b > 0)
            {
                return true;
            }
            else if (b < 0 && a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Exercise4()
        {
            double a = Convert.ToDouble(Console.ReadLine());

            if (a >= 20 && a <= 100)
                Console.WriteLine("The number is between 20 and 100");
            else
                Console.WriteLine("The number is not between 20 and 100");
        }

        public static void Exercise5()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
