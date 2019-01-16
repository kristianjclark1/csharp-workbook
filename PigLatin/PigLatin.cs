using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string firstThird = alphabet.Substring(0, 8);
            string secondThird = alphabet.Substring(8, 8);
            string thirdThird = alphabet.Substring(17);

            Console.WriteLine("First Third: " + firstThird);
            Console.WriteLine("Second Third: " + secondThird);
            Console.WriteLine("Third Third: " + thirdThird);

            
            

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            return word;
        }
    }
}
