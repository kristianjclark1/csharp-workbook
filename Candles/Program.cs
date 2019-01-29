using System;

namespace Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candles = new int[] { 6, 1, 8, 4, 9, 2 };
            int length = candles.Length;
            int count = BirthdayCakeCounter(candles.Length, candles);
            System.Console.WriteLine($"Can blow out {count} candles");

        }

        public static int BirthdayCakeCounter(int length, int[] candles)
        {
            int tallest = 0;
            int count = 0;

            foreach (var candle in candles)
            {
                if (candle > tallest)
                {
                    tallest = candle;
                    count = 0;
                }
                if (candle == tallest)
                {
                    return count++;
                }
            }
            return count;









        }
    }
}
