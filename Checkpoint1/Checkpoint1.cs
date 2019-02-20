using System;
using System.Collections.Generic;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();




            /* int i, fact = 1, number;

            System.Console.WriteLine("Enter any Number");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            System.Console.WriteLine("Factor of" + number + " is: " + fact);

            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);

            System.Console.WriteLine($"Random number between 1 and 10 is (rand)");
            */
        }
        static void Problem1()
        {
            System.Console.WriteLine("Program1");
            int i = 0;
            int count = 0;
            for (i = 1; i <= 100; i++)
            {
                //is it 100 / 3 or i / 3?//
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            System.Console.WriteLine("there are {0} numbers divisible by 3", count);

            System.Console.WriteLine();
        }

        static void Problem2()
        {
            System.Console.WriteLine("Program2");
            List<string> checkpointList = new List<string>();
            int sum = 0;
            string ch1 = "";
            Console.WriteLine("Please continue to enter numbers or 'ok' to exit: ");

            do
            {
                ch1 = Console.ReadLine();
                checkpointList.Add(ch1);
            }
            while (ch1 != "ok");

            int number = 0;
            foreach (string s in checkpointList)
            {
                bool result = Int32.TryParse(s, out number);
                if (result)
                {
                    sum = sum + number;
                }
            }
            System.Console.WriteLine("The sum of your numbers is {0}", sum);

            System.Console.WriteLine();
        }
        static void Problem3()
        {
            System.Console.WriteLine("Program3");

            System.Console.WriteLine("Enter any Number");
            int userInput = int.Parse(Console.ReadLine());
            int originaluserinput = userInput;
            for (int i = userInput - 1; i >= 1; i--)
            {
                userInput = userInput * i;
            }
            System.Console.WriteLine("Factorial of " + originaluserinput + " is: " + userInput);

            System.Console.WriteLine();
        }
        static void Problem4()
        {
            System.Console.WriteLine("Program4");
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 11);
            System.Console.WriteLine($"Random number between 1 and 10 is (rand)");

            for (int i = 4; i > 0; i--)
            {
                System.Console.WriteLine("Guess");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == rndNumber)
                {
                    System.Console.WriteLine("You Won!");
                    break;
                }
                else if (userInput != rndNumber)
                {
                    System.Console.WriteLine("Try again");
                }
                if (i == 1)
                {
                    System.Console.WriteLine("You Lose");
                }
                System.Console.WriteLine();
            }


        }
        static void Problem5()
        {
            System.Console.WriteLine("Problem5");

            System.Console.WriteLine("Input a series of numbers separated by commas: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            System.Console.WriteLine("Highest number is:  " + max);





        }

    }
}
