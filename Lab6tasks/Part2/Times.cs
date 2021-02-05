using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Times
    {
        public void TwoUsTimes()
        {
            var date1 = new DateTime(2020, 1, 15);
            var date2 = new DateTime(2019, 3, 7);

            Console.WriteLine(new DateTime(date2.Ticks + date1.Ticks));
        }

        public void SecondsToTime(int totalSeconds)
        {

            var hours = totalSeconds / 3600;
            totalSeconds -= hours * 3600;
            var minutes = totalSeconds / 60;
            totalSeconds -= minutes * 60;
            var seconds = totalSeconds;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");

        }

         public void TimeToSeconds(int hours, int minutes, int seconds)
        {
            seconds = hours * 3600 + minutes * 60 + seconds;
            Console.WriteLine(seconds);
        }
    }
}
