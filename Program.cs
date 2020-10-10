using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean datatype
            bool type = true;
            Console.WriteLine(type);

            // integral datatypes
            // signed - sbyte, int, long, short
            int i = 10; // Assignment operator
            Console.WriteLine(i);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", int.MinValue, int.MaxValue);

            sbyte sb = 126;
            Console.WriteLine(sb);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", sbyte.MinValue, sbyte.MaxValue);

            long l = 594913284923;
            Console.WriteLine(l);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", long.MinValue, long.MaxValue);

            short s = 32666;
            Console.WriteLine(s);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", short.MinValue, short.MaxValue);

            // unsigned - byte, char, ushort, uint, ulong
            byte b = 245;
            Console.WriteLine(b);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", byte.MinValue, byte.MaxValue);

            char ch = 'R';
            Console.WriteLine(ch);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", char.MinValue, char.MaxValue);

            ushort us = 55655;
            Console.WriteLine(us);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", ushort.MinValue, ushort.MaxValue);

            uint ui = 509123;
            Console.WriteLine(ui);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", uint.MinValue, uint.MaxValue);

            ulong ul = 5123456098;
            Console.WriteLine(ul);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", ulong.MinValue, ulong.MaxValue);

            // floating types
            // float and doubles datatypes
            float f = 3.7330645f;
            Console.WriteLine(f);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", float.MinValue, float.MaxValue);

            double d = 555.2343543;
            Console.WriteLine(d);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", double.MinValue, double.MaxValue);

            // decimal types
            decimal dec = 94234.45m;
            Console.WriteLine(dec);
            Console.WriteLine("Minimum value = {0} Maximum value = {1}", decimal.MinValue, decimal.MaxValue);

            // String data type
            // Escape sequences can also be used. Provided in a MSDN documents for C#
            string str = "Name";
            Console.WriteLine(str);

            // verbatim literal
            string path = @"C:\users\rohan";
            Console.WriteLine(path);
        }
    }
}
