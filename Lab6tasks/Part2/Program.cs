using System;
using System.Collections.Generic;

namespace Part2
{
    class Program
    {

        static void StudCheck()
        {
            var student = new Student();
            student.name = "Ihor";
            student.studID = "w62348";
            student.Grades = new List<int>() { 5, 5, 5, 5, 5, 4 };
            Console.WriteLine(student.Final);
        }

        static void InchCheck()
        {
            var twoDistances = new Dist();
            twoDistances.inches = 9;
            twoDistances.feet = 2;
            Console.WriteLine(twoDistances.AddInch);
        }

        static void DateCheck()
        {
            var dateTest = new Times();
            dateTest.TwoUsTimes();
        }

        static void SecondsCheck()
        {
            var secondTest = new Times();
            secondTest.SecondsToTime(2600);
        }

        static void TimeToSecondsCheck()
        {
            var test = new Times();
            test.TimeToSeconds(2, 7, 16);
        }

        static void ElectionCheck()
        {
            var test = new Elections();
            test.candidates = new Dictionary<string, int>
            {
                {"Baiden",420},
                {"Trump", 30},
            };
            test.GetWinner();
        }

        static void AccountCheck()
        {
            var account = new Account("Ihor", 500);
            account.WithDraw(300);
            account.Deposit(400);
            Console.WriteLine(account.Personal);
        }
    }
}
