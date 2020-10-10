using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF ELSE STATEMENTS
            Console.WriteLine("Please enter a number");
            int Number = int.Parse(Console.ReadLine());

            if(Number == 1) {
                Console.WriteLine("Your number is one.");
            }
            else {
                Console.WriteLine("Your number is not one");
            }

            // There is a difference between single (|) and double (||).
            // When an double sign is there it only checks the first condition, 
            // if there is single sign it checks both the conditions.
            // Same applies to (&) and double (&&) 

            if (Number == 10 | Number == 20) {
                Console.WriteLine("Your number is something");
            }

            // SWITCH STATEMENTS
            Console.WriteLine("Please enter a number");
            int NumberSwitch = int.Parse(Console.ReadLine());

            switch(NumberSwitch) 
            {
                case 10:
                {
                    Console.WriteLine("Your number is 10");
                    break;
                }
                case 20:
                {
                    Console.WriteLine("Your number is 20");
                    break;
                }
                case 30:
                {
                    Console.WriteLine("Your number is 30");
                    break;
                }
                default:
                    Console.WriteLine("None");
                    break;
            } 

            // SWITCH STATEMENTS WITH GOTO STATEMENTS
            int totalCoffeeCost = 0;

            Console.WriteLine("Welcome to the coffee station.");
            Console.WriteLine("Choose the size of the coffee.");
            start: // labels
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;

                case 2:
                    totalCoffeeCost += 2;
                    break;

                case 3:
                    totalCoffeeCost += 3;
                    break;

                default:
                    Console.WriteLine("Your choice {0} is invalid.", userChoice);
                    goto start;
            }
            decide: // label
            Console.WriteLine("Do you want another coffee?");
            Console.WriteLine("Yes OR No");
            string choice = Console.ReadLine();

            switch (choice.ToUpper()) {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid.", choice);
                    goto decide;
            }

            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Your bill amount is {0}", totalCoffeeCost);
            
        }
    }
}
