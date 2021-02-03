using System;
using System.Security.Cryptography;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in Celsius: ");
            var celsius = Console.ReadLine();
            var celsius_double = Convert.ToDouble(celsius);

            Console.WriteLine("in Kelvin: " + ToKelvin(celsius_double));

            Console.WriteLine("to Farengeit: " + ToFareng(celsius_double));


        }

        static double ToKelvin(double cels)
        {
            double difToKelv = Math.Round(273.15f,2);

            var kelv =cels + difToKelv;
            return kelv;
        }

        static double ToFareng(double cels)
        {
            var fareng = (cels * 9 / 5) + 32;
            return fareng;
        }
    }
}
