using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for testing
        }

        public static void Exercise1()
        {
            Console.WriteLine("enter the 3 numbers");
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var min = arr[0];
            var max = arr[0];

            for (int i = 1; i < 3; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("the gratest: " + max);
            Console.WriteLine("the smallest: " + min);
        }

        public static void Exercise2()
        {
            Console.WriteLine("enter the 3 grades");
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = 0;

            for (int i = 1; i < 3; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("the average grade: " + sum/3);
        }

        public static void Exercise3()
        {
            var a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("the number is negative");
            }
            else
            {
                Console.WriteLine("the number is 0");
            }
        }

        public static void Exercise4()
        {
            var a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }

        public static void Exercise5()
        {
            var ch = Console.ReadLine();

            if (ch.Length > 1)
            {
                Console.WriteLine("it is a string, not a character");
            }
            else
            {
                Console.WriteLine("it is a character");
            }
        }

        public static void Exercise6()
        {
            var mon = Convert.ToInt32(Console.ReadLine());
            if (mon > 0 && mon <= 12)
            {
                Console.WriteLine("the number of days is: " + DateTime.DaysInMonth(DateTime.Now.Year, mon));
            }

        }
    }
}
