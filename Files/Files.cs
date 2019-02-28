using System;
using System.IO;

namespace Files
{
    class Program
    {
        //Write a program that creates a text file that says "This is a text file.".
        //Write a program that edits the previous file to say "This is a text file, and I can edit it."
        //Write a program that deletes the previously created file.
        //Write a program that reads a text file and displays the number of words.
        //Write a program that reads a text file and displays the longest word in the file.

        static void Main(string[] args)
        {
            string textFile = string.Join("This is a Text File", args);





            Console.WriteLine("Hello World!");
        }
        private static void SimpleWay(string[] args)
        {
            string textToWrite = string.Join("", args);

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string documentName = "Simple way";
            string docummentExtension = "txt";
            string fullPathtoFile = $"{documentsPath}/{documentName}.{documentExtension}";

            #region I don't want you to copy paste this section...

            System.Console.WriteLine($"Press any key to close {documentName}.{documentExtension} file");
            System.Console.ReadLine();
        }
    }
}
