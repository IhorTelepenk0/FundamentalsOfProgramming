using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part2
{
    class Elections
    {
        public Dictionary<string, int> candidates { get; set; }

        public void GetWinner()
        {
            Console.WriteLine(candidates.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
        }
    }
}
