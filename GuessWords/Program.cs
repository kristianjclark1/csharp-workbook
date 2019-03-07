using System;
using System.IO;

namespace GuessWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\kristianclark\Documents\words_alpha.txt");
            Random rng = new Random();
            int r = rng.Next(lines.Length);
            //creates random number and selects word for that number from array
            string compWord = lines[r];

            System.Console.WriteLine("The word I picked is {0}", compWord);
            string userGuess = Console.ReadLine();
            int compNum = Array.IndexOf(lines, compWord);
            int userNum = Array.IndexOf(lines, userGuess);
            //Console.WriteLine(userNum);

            while (compNum != userNum)
            {
                if (compNum < userNum)
                {
                    Console.WriteLine("That guess comes after my word! Try again!");
                }
                else if (userNum < compNum)
                {
                    Console.WriteLine("That guess comes before my word! Try again!");
                }
                userGuess = Console.ReadLine();
                userNum = Array.IndexOf(lines, userGuess);
            }

            if (compNum == userNum)
            {
                Console.WriteLine("You Win!");
            }
            Console.WriteLine();

        }
    }
}
