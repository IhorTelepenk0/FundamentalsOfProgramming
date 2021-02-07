using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    public struct EmployeeInfo
    {
        public string[] persDetails;

        public void PutFullName(string name, string surname)
        {
            persDetails[0] = name;
            persDetails[1] = surname;
        }
    }

    class Employee
    {
    }
}
