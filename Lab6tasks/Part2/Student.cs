using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part2
{
    class Student
    {
        public string name { get; set; }
        public string studID { get; set; }
        public List<Int32> Grades { get; set; }
        public double Final => Grades.Average();

    }
}
