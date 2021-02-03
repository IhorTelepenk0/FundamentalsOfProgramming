using System;
using System.Collections.Specialized;
using System.Dynamic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
