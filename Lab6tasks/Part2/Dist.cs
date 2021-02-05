using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Dist
    {
        public double feet { get; set; }
        public double inches { get; set; }
        public double AddInch => feet * 12.0 + inches;
    }
}
