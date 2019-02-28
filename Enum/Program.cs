using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints out the day of the week your birthday will fall on for which ever year you type in.
            int myBirthday = 10;
            int DayOfWeekTracker = 0;

            foreach (var item in Enum.GetValues(typeof(System.DayOfWeek)))
                foreach (var item in Enum.GetValues(typeof(MonthsOfYearWithNumbers)))
                {
                    var dayEnum = (DayOfWeek)item;
                    Console.WriteLine((int)dayEnum);
                    System.Console.WriteLine(item);
                }

            Console.WriteLine("Hello World!");
        }



        enum DayOfWeek
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        enum MonthsOfYearWithNumbers
        {
            January = 01, February = 02, March = 03, April = 04, May = 05, June = 06, July = 07, August = 08, September = 09, October = 10, November = 11, December = 12
        }
    }
}
