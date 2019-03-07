using System;
using System.IO;
using System.Collections.Generic;

namespace GuessWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"/Users/kristianclark/csharp-workbook/GuessWords/words_alpha.txt");

            Random rnd = new Random();
            int r = rnd.Next(lines.Length);
            //creates random number and selects word for that number from array
            string myWord = lines[r];

            System.Console.WriteLine("Guess my word and I will give you hints along the way");
            string userGuess = Console.ReadLine();
            int userNum = Array.IndexOf(lines, userGuess);
            int compNum = Array.IndexOf(lines, myWord);

            // System.Console.WriteLine("The word I picked is {0}", myWord);


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
