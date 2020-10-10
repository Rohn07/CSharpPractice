using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           int i = 10; // Assignment operator
            Console.WriteLine(i);

            int Number1 = 10;
            int Number2 = 2; 

            // Arthematic operators
            int Add = Number1 + Number2;
            int Sub = Number1 - Number2;
            int Divide = Number1 / Number2;
            int Remainder = Number1 % Number2;
            int Multiply = Number1 * Number2;

            Console.WriteLine("Result is {0}", Add);
            Console.WriteLine("Result is {0}", Sub);
            Console.WriteLine("Result is {0}", Divide);
            Console.WriteLine("Result is {0}", Remainder);
            Console.WriteLine("Result is {0}", Multiply);

            // Comparision operator
            // "==" and "!=" stands for "equalTo" and "notEqualTo"

            // Conditional Operator
            // && operator and || operator
            if (Number1 == 10 && Number2 == 2) {
                Console.WriteLine("Hello I am AND operator!");
            } 

            if (Number1 == 10 || Number2 == 21) {
                Console.WriteLine("Hello I am OR operator!");
            }

            // Ternary Operator
            bool isNumber = i == 24 ? true : false;
            Console.WriteLine(isNumber);
        }
    }
}
