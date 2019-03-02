using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints out the day of the week your birthday will fall on for which ever year you type in.


            //Assume the current culture is en-US
            Console.WriteLine("Please enter the year you would like to know what day your birthday falls on");
            string bdayYr = Console.ReadLine();
            DateTime dt = new DateTime(Convert.ToInt32(bdayYr), 9, 10);
            Console.WriteLine("Your birthday falls on {0} in the year {1}", dt.DayOfWeek, bdayYr);

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
