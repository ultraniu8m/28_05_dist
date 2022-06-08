using System;
using Calculations1;
namespace dist_28_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations a = new Calculations();
            TimeSpan[] startTimes = { new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), new TimeSpan(17,0,0) };
            int[]  time_ = { 30, 20 };
            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(16, 0,0);
            TimeSpan common = new TimeSpan(0, 30, 0);
            int get_isklucheniya = 0;
            double hours = (endWorkingTime - beginWorkingTime).TotalHours;
            while (beginWorkingTime <= (endWorkingTime-common))
            {
                
                if (beginWorkingTime == startTimes[get_isklucheniya])
                {
                    Console.WriteLine("got you");
                    beginWorkingTime += TimeSpan.FromMinutes(time_[get_isklucheniya]);
                    Console.WriteLine(beginWorkingTime + "-" + (beginWorkingTime + common));
                    beginWorkingTime += common;
                    get_isklucheniya += 1;
                }
                else
                {
                    Console.WriteLine(beginWorkingTime + "-" + (beginWorkingTime + common));
                    beginWorkingTime += common;
                }
                
            }
                
        }
    }
}
