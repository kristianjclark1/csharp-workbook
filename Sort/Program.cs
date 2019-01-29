using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numArray = { 23, 55, 99, 38, 65 };

            for (int i = 0; i < numArray.Length - 1; i++)
            {
                int current = numArray[i];
                int next = numArray[i + 1];
                if (current < next)
                {
                    numArray[i] = current;
                }
                else if (current > next)
                {
                    numArray[i] = next;

                }
                System.Console.WriteLine(numArray);


            }

        }
    }
}
