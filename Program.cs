using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE LOOP
            Console.WriteLine("Please enter your target:");
            int target = int.Parse(Console.ReadLine());
            int start = 0;

            while (start <= target)
            {
                Console.Write(start + " ");
                start += 2;
            }

            // DO WHILE LOOP
            string userChoice = string.Empty;
            do 
            {
                Console.WriteLine("Please enter your target:");
                int target2 = int.Parse(Console.ReadLine());
                int start2 = 0;
                
                while (start2 <= target2)
                {
                    Console.Write(start2 + " ");
                    start2 += 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue? Yes or No");

                    userChoice = Console.ReadLine().ToUpper();
                    if(userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while(userChoice == "YES");

            // FOR AND FOR EACH LOOPS
            int[] numbers = new int[3];

            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            for(int i = 0; i <numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }

            foreach (int each in numbers) {
                Console.WriteLine(each);
            }
        }
    }
}
