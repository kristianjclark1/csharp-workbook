using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting numbers from smallest to largest//
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
                    numArray[i + 1] = current;

                }



            }
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
                    numArray[i + 1] = current;

                }



            }
            foreach (var item in numArray)
            {
                System.Console.WriteLine(item.ToString());
            }

        }
    }
}
