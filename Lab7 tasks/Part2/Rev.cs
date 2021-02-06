using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Rev
    {
        public Rev(int numb)
        {
            int reverse = 0;
            while (numb != 0)
            {
                int rem = numb % 10;
                reverse = reverse * 10 + rem;
                numb /= 10;
            }

            Console.WriteLine(reverse);
        }
    }
}
