using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // array declarations and defining the size of the array.
           int[] Numbers = new int[5];

            // storing the data for the array
           Numbers[0] = 1;
           Numbers[1] = 2;
           Numbers[2] = 3;
           Numbers[3] = 4;
           Numbers[4] = 5;

           Console.WriteLine(Numbers[3]);
        }
    }
}
