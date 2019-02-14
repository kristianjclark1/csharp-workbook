﻿using System;

namespace WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {

            StringTransform transformedWord;
            string reversedword;
            transformedWord = new StringTransform();
            reversedword = transformedWord.Transform("jeff");
            stringUpperCase secondTransformer = new stringUpperCase();
            var result2 = secondTransformer.Transform("jeff");
            System.Console.WriteLine(result2);
            System.Console.WriteLine(reversedword);



        }

        public class StringTransform
        {
            public string Transform(string v)
            {
                if (v == null)
                {
                    throw new ArgumentNullException("V");
                }

                int i;
                string transformedWord = string.Empty;

                for (i = v.Length - 1; i >= 0; i--)
                {
                    transformedWord += v[i];
                }

                return transformedWord;
            }
        }

        public class stringUpperCase : StringTransform
        {
            public string Transform(string input)
            {
                return input.ToUpper();
            }
        }

    }
}

