using System;

namespace CSharpPractice
{
    public class parent
    {
        public void parentClass()
        {
            Console.WriteLine("parent class called");
        }

        // public void parentClass(string message)
        // {
        //     Console.WriteLine(message);
        // }
    }

    public class child : parent
    {
        public void childClass() 
        {
            Console.WriteLine("child class called");
        }
    }
    class Program
    {
        public static void Main()
        {
            child cc = new child();
        }
    }
}
