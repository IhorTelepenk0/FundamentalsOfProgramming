using System;

namespace class_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for testing
        }

        public static void Exercise1()
        {
            var a = Convert.ToInt32(Console.ReadLine());

            if (a % 7 == 0 || a % 3 == 0)
            {
                Console.WriteLine("This number is a multiple of 7 or 3");
            }
            else
            {
                Console.WriteLine("This number is not a multiple of 7 or 3");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("enter number 1: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if ((a > -10 && a < 10) || (b > -10 && b < 10))
            {
                Console.WriteLine("there is an integer between 10 and -10");
            }
            else
            {
                Console.WriteLine("No number between 10 and -10");
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("enter number 1: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a < 100 && b > 200)
            {
                Console.WriteLine("one of the numbers is less than 100 and the other is greater than 200");
            }
            else
            {
                Console.WriteLine("one of the numbers is not less than 100 and the other is not greater than 200");
            }
        }

        public static void Exercise4()
        {
            Console.WriteLine("enter the radius: ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area: {Math.PI * a * a}; Perimeter: {2 * Math.PI * a}");
        }

        public static void Exercise5()
        {
            Console.WriteLine("enter the distance: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the time: ");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Speed: {a / b} (km/h), Speed: { (a / b) / 1.609} (mph)");
        }

        public static void Exercise6()
        {
            Console.WriteLine("Enter radius: ");
            var rad = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Surface: {4 * Math.PI * rad * rad}; Volume: { (4 / 3) * Math.PI * rad * rad * rad}");
        }

        public static bool Exercise7()
        {
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
