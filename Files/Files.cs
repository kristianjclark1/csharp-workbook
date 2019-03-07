using System;
using System.Text;
using System.IO;
using System.Collections.Generic;


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
            string myFile = @"C:\Users\kristianclark\Desktop\myFile.txt";
            using (StreamWriter sw = File.CreateText(myFile))
            {
                sw.WriteLine("This is a Text File");
                sw.WriteLine("This is a Text File, and I can edit it");

            }
            using (StreamReader sr = File.OpenText(myFile))
            //prints file that was created(myFile)
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
            System.Console.WriteLine();

            string editText = File.ReadAllText(@"C:\Users\kristianclark\Desktop\myFile.txt");
            //created string to store data from my file
            //preparing to edit text in my created file
            editText = editText.Replace("and I can edit it", "and I love it");
            File.WriteAllText(@"C:\Users\kristianclark\Desktop\myFile.txt", editText);

            using (StreamReader sr2 = File.OpenText(myFile))
            //reprint console the created file with edits
            {
                string line;
                while ((line = sr2.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
            if (File.Exists(myFile))
            //deletes my file
            {
                try
                {
                    File.Delete(myFile);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                }
            }
        }




    }
}


