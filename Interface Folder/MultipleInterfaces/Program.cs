using System;

namespace MultipleInterfaces
{

    public interface ICommunicate
    {
        void CallPhone();

        void SendEmail(string Title, string Body);

        void SendSMS(string Title, string Body);

        void SendFax(string Title, string Body);
    }
    public interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }

        void Introduce();

        void Print();

        string To_String();

    }

    public abstract class ABSPerson : IPerson, ICommunicate
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

        public void CallPhone()
        {
            Console.WriteLine("Calling Phone... :-)");
        }

        public void SendEmail(string Title, string Body)
        {
            Console.WriteLine("Email Sent :-)");
        }

        public void SendSMS(string Title, string Body)
        {
            Console.WriteLine("SMS Sent :-)");
        }

        public void SendFax(string Title, string Body)
        {
            Console.WriteLine("Fax Sent :-)");
        }

    }

    public class clsEmployee : ABSPerson
    {
        public int EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} {Surname}, and my employee ID is {EmployeeId}.");
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

            Employee.SendFax("hi", "oms");
            Employee.SendEmail("oms", "body");
            Employee.CallPhone();
            Employee.SendSMS("oms", "this is sms");

            Console.WriteLine("This is ToString Method Body: {0}", Employee.To_String());
        }
    }
}