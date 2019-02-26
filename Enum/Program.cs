using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {



            var point = new System.Drawing.Point(0, 0);
            point = new System.Drawing.Point(5, 5);
            point.X = point.X * point.X;
            point.Y = point.Y * point.Y;

            //foreach(var item in Enum.Getvalues(typeof(System.DayOfWeek)))
            //foreach (var item in Enum.GetValues(typeof(MonthsOfYearWithNumbers)))
            //{
            //var monthEnum = (DayOfWeek)item;
            //Console.WriteLine((int)monthEnum);
            // System.Console.WriteLine(item);
            // }

            //Console.WriteLine("Hello World!");
        }

        public struct StructPoint
        {

            public int y { get; set; }
            public int X { get; set; }

            public StructPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

        }
        public struct ClassPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        //enum MonthsofYear
        //{
        // January, February, March, April, May, June, July, August, September, October, November, December
        // }

        // enum MonthsOfYearWithNumbers
        // {
        //  January = 01, February = 02, March = 03, April = 04, May = 05, June = 06, July = 07, August = 08, September = 09, October = 10, November = 11, December = 12
        //}
    }
}
