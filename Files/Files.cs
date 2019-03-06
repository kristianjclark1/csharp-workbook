using System;
using System.Collections;
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
            string textFile2 = string.Join("This is a Text File, and I can edit it", args);





            Console.WriteLine("Hello World!");
        }
        private static void SimpleWay(string[] args)
        {
            string textToWrite = string.Join("", args);

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string documentName = "Simple way";
            string documentExtension = "txt";
            string fullPathtoFile = $"{documentsPath}/{documentName}.{documentExtension}";

            using (FileStream fs1 = File.Create(fullPathtoFile)) ;
            using (StreamWriter sw = new StreamWriter(fs1)) ;
            {
                sw.WriteLine(textFile2);
            }

            System.Console.WriteLine("Finished");
            return fullPathtoFile;

            // #region I don't want you to copy paste this section...

            //  System.Console.WriteLine($"Press any key to close {documentName}.{documentExtension} file");
            //  System.Console.ReadLine();
        }
    }
}