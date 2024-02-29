using System;

namespace Exp3
{
    public class Employee
    {
        public string name, designation;
        public int bsalary, noofexp, insurance;
        public float hra, ta, grosspay;
        public Employee(string name, string designation, int bsalary, int noofexp, int insurance)
        {
            this.name = name;
            this.designation = designation;
            this.bsalary = bsalary;
            this.noofexp = noofexp;
            this.insurance = insurance;
        }
        public void salary()
        {
            hra = (20 / 100) * bsalary;
            ta = (10 / 100) * bsalary;
            grosspay = bsalary + hra + ta - insurance;
        }
        public void display()
        {
            Console.WriteLine("{0} having {1} yrs of experience, working as {2}", this.name, this.noofexp, this.designation);
            Console.WriteLine("Receives {0} as his/her salary", this.grosspay);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Ronick", "ML Engineer", 120000, 5, 20000);
            emp1.salary();
            Employee emp2 = new Employee("Ashwin", "Data Scientist", 90000, 2, 10000);
            emp2.salary();
            emp1.display();
            emp2.display();
            Console.ReadLine();
        }
    }
}
