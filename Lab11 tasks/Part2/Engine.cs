using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Engine
    {
        public virtual void EngineProps(double power, int rpm, int cylinder)
        {
            Console.WriteLine($"The characteristics are: {power}; {rpm}; {cylinder}.");
        }
    }

    class EngineHH27:Engine
    {
        public override void EngineProps(double power, int rpm, int cylinder)
        {
            Console.WriteLine($"The power is {power}, RPM characteristics: {rpm}, the cylinder size is {cylinder}");
        }
    }
}
