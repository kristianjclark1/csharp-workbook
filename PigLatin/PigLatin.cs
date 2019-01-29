using System;

namespace PigLatin
{
    class Program
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

            string firstLetter = word.Substring(0, 1);
            string restWord = word.Substring(1);
            // your code goes here
            return restWord + firstLetter + "ay";

            char[] firstVowelIndex = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            string firstPart = word.Substring(0, firstVowelIndex);
            string secondPart = word.Substring(firstVowelIndex);

            return secondPart + firstPart + "ay";
        }
    }
}
