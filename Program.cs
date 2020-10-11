using System;

namespace CSharpPractice
{
    public class Employee
    {
        public string firstName;
        public string lastame;

        public void printFullName()
        {
            Console.WriteLine(firstName+" "+lastame);
        }
    }

    public class partTimeEmployee : Employee
    {
        public new void printFullName() // new keyword is required to hide the method in the parent class.
        {
            Console.WriteLine(firstName+" "+lastame+ "- Contractor");
            // base.printFullName(); // this method will call the parent class method. first way to call a base class method.
        }
    }

    public class fullTimeEmployee : Employee
    {
        public new void printFullName() // Method hiding with the new keyword
        {
            Console.WriteLine(firstName+" "+lastame+ "- Employee");
        }
    }

    public class Program
    {
        public static void Main()
        {
            fullTimeEmployee FTE = new fullTimeEmployee(); // creating a refernece for the class
            FTE.firstName = "Rohan";
            FTE.lastame = "Buddhdev";
            FTE.printFullName();

            partTimeEmployee PTE = new partTimeEmployee();
            PTE.firstName = "Rishabh";
            PTE.lastame = "Shah";
            PTE.printFullName();
            // ((Employee)PTE).printFullName(); // this will call the parent class method // 2nd way to call the parent class employee
        }
    }
}
