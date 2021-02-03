using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine("enter the size of the array: ");
            var n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("enter the array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(array);

            Console.WriteLine($"Mean: {array.Average()}, Median: { Median(array)}, Mode: { Mode(array)}, Standard deviation: {StdDev(array)}");

            double Median(int[] arr)
            {
                Array.Sort(arr);

                if (arr.Length % 2 == 0)
                    return (arr[(arr.Length / 2) - 1] + arr[(arr.Length / 2)]) / 2.0;
                else
                    return arr[arr.Length / 2];
            }

            int Mode(int[] arr)
            {
                int n = arr.Length;
                int count = 0, prevCount = 0;
                int mode = 0;
                for (int i = 0; i < n; i++)
                {

                    for (int j = i; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }

                    if (count > prevCount)
                    {
                        mode = arr[i];
                        prevCount = count;
                    }
                }

                return mode;
            }

            double StdDev(int[] arr)
            {
                double avg = arr.Average();
                return Math.Sqrt(arr.Average(v => Math.Pow(v - avg, 2)));
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("enter the size of the array: ");
            var n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("enter the numbers: ");
            for (int i = n - 1; i >= 0; i--)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("enter the size of the array: ");
            var n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("enter the numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var dict = new Dictionary<int, int>();

            foreach (int a in arr)
            {
                if (dict.ContainsKey(a))
                    dict[a] = dict[a] + 1;
                else
                    dict[a] = 1;
            }

            foreach (KeyValuePair<int, int> el in dict)
            {

                if (el.Value > 1)
                {
                    Console.WriteLine($"Duplicate of {el.Key} appears {el.Value} times");
                }

            }

        }

        public static void Exercise4()
        {
            Console.WriteLine("enter the sizes of the first matrix: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the sizes of the second matrix: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());

            int i, j, k;
            int[,] resMatr = new int[n1,m1];

            Console.WriteLine("enter the first matrix: ");
            int[,] matr1 = new int[n1,m1];
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < m1; j++)
                {
                    matr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("enter the second matrix: ");
            int[,] matr2 = new int[n2, m2];
            for (i = 0; i < n2; i++)
            {
                for (j = 0; j < m2; j++)
                {
                    matr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int sum = 0;
            for (i = 0; i < n1; i++)
            for (j = 0; j < m2; j++)
                resMatr[i, j] = 0;
            for (i = 0; i < n1; i++) 
            {
                for (j = 0; j < m2; j++)    
                {
                    sum = 0;
                    for (k = 0; k < m1; k++)
                        sum = sum + matr1[i, k] * matr2[k, j];
                    resMatr[i, j] = sum;
                }
            }
            Console.WriteLine("The multiplication of two matrices is: ");
            for (i = 0; i < n1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m2; j++)
                {
                    Console.Write(" " + resMatr[i, j]);
                }
            }
        }

        public static void Exercise5()
        {
            int i, j, m, n;

            Console.Write("Enter the number of rows and columns of the matriX: ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[n, m];
            int[,] arr2 = new int[n, m];

            Console.Write("enter the elements of the matrix: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {

                    arr2[j, i] = arr1[i, j];
                }
            }

            Console.Write("the matrix after transpose: ");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine(" " + arr2[i, j]);
                }
            }
        }
    

        public static void Exercise6()
        {
            int i, j;
            int[,] arr1 = new int[3, 3];
            int det = 0;

            Console.Write("enter the elements of the matrix: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 3; i++)
                det = det + (arr1[0, i] * (arr1[1, (i + 1) % 3] * arr1[2, (i + 2) % 3] - arr1[1, (i + 2) % 3] * arr1[2, (i + 1) % 3]));

            Console.WriteLine("the determinant of the matrix is: " + det);
        }
    }
}
