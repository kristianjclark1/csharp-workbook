using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var source = new int[] { 1, 2, 3, 4 };
            var reults =
            from i in source
            where true
            select i;

            int total = source.Where(x => x % 2 == 0).Select(Square).Sum();


        }
        public void int Square(int i)
        {

        }

    }
}
