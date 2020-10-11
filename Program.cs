using System;
// METHOD OVER LOADING
namespace CSharpPractice
{
    public class Program
    {
        public static void Add(int first, int second)
        {
            Console.WriteLine("Sum is {0}", first+second);
        }
        public static void Add(int first, int second, out int Sum) // same method name, different parameters
        {
            Sum = first + second;
            Console.WriteLine("Sum is {0}", Sum);
        }
        public static void Main()
        {
            int sum;
            Add(10,20);
            Add(20,30,out sum);
        }
    }
}
