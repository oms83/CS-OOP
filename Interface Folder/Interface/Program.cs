using System;

namespace Interface
{
    public interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }

        void Introduce();

        void Print();

        string To_String();

    }

    public abstract class ABSPerson : IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void Introduce();

        public void Print()
        {
            Console.WriteLine("Hi, i'm the print method");
        }
        public string To_String()
        {
            return "Hi this is the complete string....";
        }
    }

    public class clsEmployee : ABSPerson
    {
        public int EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} {Surname}, and my employee ID is {EmployeeId}.");
        }

        public void SedEmail()
        {
            Console.WriteLine("Email Sent :-)");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee();
            Employee.Name = "Omer";
            Employee.Surname = "MEMES";
            Employee.EmployeeId = 8320;

            Employee.Print();
            Employee.Introduce();
            Console.WriteLine("This is ToString Method Body: {0}", Employee.To_String());
        }
    }
}