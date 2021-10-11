using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Attendance
    {
        public delegate void Message(string message);
        public static event Message Not;
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void Event()
        {
            Not += DisplayMessage;
            var studList = new List<string>() {"Ihor", "Adam", "Steven", "Methew", "Asanali"};
            foreach (var student in studList)
            {
                if (student == "Steven" || student == "Mathew")
                    Not?.Invoke("The student is banned.");
                else
                    Not?.Invoke("You're welcome!");
            }
        }
    }
}
