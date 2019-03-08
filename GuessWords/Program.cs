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

            System.Console.WriteLine("Please enter a word to see if it comes before or after the random word");
            string userGuess = Console.ReadLine();
            int userNum = Array.IndexOf(lines, userGuess);
            int compNum = Array.IndexOf(lines, myWord);


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
