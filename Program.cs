using System;
// METHOD OVER RIDING
// POLYMORPHISM 
namespace CSharpPractice
{
    public class Employee
    {
        public string firstName = "parent";
        public string lastame = "class";

        public virtual void printFullName() // adding a virtual keyword would help us to override the parent class method in child class. 
        {
            Console.WriteLine(firstName+" "+lastame);
        }
    }

    public class partTimeEmployee : Employee
    {
        public override void printFullName() // adding the override method 
        {
            Console.WriteLine(firstName+" "+lastame+ "- Part time");
        }
    }

    public class fullTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName+" "+lastame+ "- Full time");
        }
    }

    public class interns : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName+" "+lastame+ "- Intern");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new partTimeEmployee();
            employees[2] = new fullTimeEmployee();
            employees[3] = new interns();

            foreach (var item in employees)
            {
                item.printFullName();
            }
        }
    }
}
