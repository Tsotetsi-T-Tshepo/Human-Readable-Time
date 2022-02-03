using System;

namespace Human_Readable_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetReadableTime(60));
        }
    }
    class Kata
    {
        public static string GetReadableTime(int seconds)
        {
            int timeInSeconds = seconds, timeInMinuetes=0, timeInHours=0;

            if (seconds>=60)
            {
                timeInMinuetes = seconds / 60;
                timeInSeconds = timeInSeconds % 60;
            }

            if(timeInMinuetes>60)
            {
                timeInHours = timeInMinuetes / 60;
                timeInMinuetes = timeInMinuetes % 60;
            }

            return $"{timeInHours.ToString("D2")}:{timeInMinuetes.ToString("D2")}:{timeInSeconds.ToString("D2")}";



        }
    }
}
