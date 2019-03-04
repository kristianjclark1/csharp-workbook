using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            {
                var dayEnum = (DayOfWeek)item;
                System.Console.WriteLine(dayEnum.ToString());
            }

            var point = new System.Drawing.Point(0, 0);
            point = new System.Drawing.Point(5, 5);
            point.X = point.X * point.X;
            point.Y = point.Y * point.Y;
        }



        enum DayOfWeek
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }


        public struct structPoint
        {
            public structPoint(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
        }
        public struct ClassPoint
        {
            public int X { get; set; }
            public int Y { get; set; }

        }


    }
}
