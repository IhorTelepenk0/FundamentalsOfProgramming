using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    abstract class Bank
    {
        public int Balance { get; set; }
        public void GetBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}
