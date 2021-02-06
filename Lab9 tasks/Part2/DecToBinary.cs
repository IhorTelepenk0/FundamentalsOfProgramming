using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class DecToBinary : MiddleClass
    {
        public DecToBinary(int dec)
        {
            Console.WriteLine(Convert.ToString(dec, 2));
        }
    }
}
