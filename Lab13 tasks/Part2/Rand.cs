using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Rand
    {
        delegate int Rnd();

        public static int GetRand()
        {
            var random = new Random();
            return random.Next();
        }

        public static void Delegate()
        {
            Rnd rnd;
            rnd = GetRand;
            Console.WriteLine(rnd());

        }
    }
}
