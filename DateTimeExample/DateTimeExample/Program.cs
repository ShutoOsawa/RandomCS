using System;

namespace DateTimeExample
{
     class Program
    {
        static void Main(string[] args)
        {
            string timeOfDay = SetTime.GetTimeOfDay(DateTime.Now);
            Console.WriteLine(timeOfDay);

        }

        
    }


    public class SetTime
    {
        public static string GetTimeOfDay(DateTime time)
        {
            if (time.Hour >= 0 && time.Hour < 6)
            {
                return "Night";
            }
            if (time.Hour >= 6 && time.Hour < 12)
            {
                return "Morning";
            }
            if (time.Hour >= 12 && time.Hour < 18)
            {
                return "Afternoon";
            }
            return "Evening";
        }
    }
    
}
