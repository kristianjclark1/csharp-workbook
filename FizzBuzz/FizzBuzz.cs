using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                //integers divisible by 3 and 5 will be renamed FizzBuzz//
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz!");
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }


            }

        }
    }
}
