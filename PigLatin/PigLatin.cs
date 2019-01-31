using System;

namespace PigLatin
{
    public class Program
    {
        public static void Main()
        {

            System.Console.WriteLine("Translate word: ");
            string engWord = Console.ReadLine();
            string PigLatin = TranslateWord(engWord);
            System.Console.WriteLine(PigLatin);








            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string TranslateWord(string word)
        {


            int firstVowelIndex = word.IndexOfAny(new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' });
            if (firstVowelIndex == 0)
            {
                return word + "yay";
            }
            else if (firstVowelIndex != 0)
            {
                string firstLetter = word.Substring(0, 1);
                string restWord = word.Substring(1);
                // your code goes here
                return restWord + firstLetter + "ay";
            }

            return word;

        }
    }
}