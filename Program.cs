using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last your name.");
            string lastName = Console.ReadLine();

            // concate method to write on console
            Console.WriteLine("Hello " +firstName+lastName+ "!");
            // placeholder method to write on console
            Console.WriteLine("Welcome {0}, {1}", firstName, lastName);
        }
    }
}
