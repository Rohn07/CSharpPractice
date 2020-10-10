using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program(); // creating a instance.
            // p.EvenNumbers(); // calling a method with the help of instance.
            Program.EvenNumbers(60); // static methods don't need an instance for calling.

            int sum = p.AddNumbers(30,40);
            Console.WriteLine(sum);
        }
        // instance method.
        //public void EvenNumbers()
        // static method
        public static void EvenNumbers(int target) 
        {
            int number = 0;
            while (number  <= target) {
                Console.WriteLine(number);
                number += 2;
            }
        }
        public int AddNumbers(int a, int b) 
        {
            return a + b;
        }
    }
}
