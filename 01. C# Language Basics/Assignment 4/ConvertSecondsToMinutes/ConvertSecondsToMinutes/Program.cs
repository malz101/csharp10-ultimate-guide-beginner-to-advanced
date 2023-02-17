//Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
//seconds = 288970

//The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"

//Output: 3 days, 8 hours, 16 minutes, 10 seconds

using System;

namespace ConvertSecondsToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            long durationInSeconds;
            long days;
            int hours;
            int minutes;
            int seconds;

            //program name
            Console.WriteLine("*Convert Seconds To Minutes*");
            Console.WriteLine();

            Console.Write("Seconds: ");
            durationInSeconds = Convert.ToInt64(Console.ReadLine());

            days = durationInSeconds / 86400;
            hours = (int)(durationInSeconds % 86400) / 3600;
            minutes = (int)(durationInSeconds % 3600) / 60;
            seconds = (int)(durationInSeconds % 60);

            Console.WriteLine($"Output: {days} days, {hours} hours, {minutes} minutes, {seconds} seconds");

            Console.ReadKey();


        }
    }
}
