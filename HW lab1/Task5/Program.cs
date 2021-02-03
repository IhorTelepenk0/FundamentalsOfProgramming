using System;
using System.Collections.Specialized;
using System.Numerics;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexad;
            hexad = Console.ReadLine();

            Console.WriteLine(DecimalFromHexadecimal(hexad));
        }

        static int DecimalFromHexadecimal(string hexad)
        {

            int lenHex = hexad.Length;
            int[] hexadNumbs = new int[lenHex];
            HexadstringToIntArr(hexad, hexadNumbs);

            double res = 0, powCounter = 0;

            for (int i = (lenHex - 1); i >= 0; i--)
            {
                res += hexadNumbs[i] * (Math.Pow(16.0f, powCounter));
                powCounter++;
            }

            int intRes = Convert.ToInt32(res);
            return intRes;
        }

        static void HexadstringToIntArr (string hexad, int[] hexadNumbs)
        {
            char[] hexadArr;
            hexadArr = hexad.ToCharArray();
            int lenHex = hexad.Length;

            

            for (int i = 0; i < lenHex; i++)
            {
                if (hexadArr[i] == 'A')
                    hexadNumbs[i] = 10;
                else
                {
                    if (hexadArr[i] == 'B')
                        hexadNumbs[i] = 11;
                    else
                    {
                        if (hexadArr[i] == 'C')
                            hexadNumbs[i] = 12;
                        else
                        {
                            if (hexadArr[i] == 'D')
                                hexadNumbs[i] = 13;
                            else
                            {
                                if (hexadArr[i] == 'E')
                                    hexadNumbs[i] = 14;
                                else
                                {
                                    if (hexadArr[i] == 'F')
                                        hexadNumbs[i] = 15;
                                    else
                                    {
                                        hexadNumbs[i] = int.Parse(new string(hexadArr[i], 1));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
