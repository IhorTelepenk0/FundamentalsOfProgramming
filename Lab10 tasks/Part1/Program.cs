using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Subclass1();
            var obj2 = new Subclass2();

            obj1.message();
            obj2.message();
        }
    }
}
