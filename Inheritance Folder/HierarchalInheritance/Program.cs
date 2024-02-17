using System;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
    }
}


public class Employee : Person
{
    public int EmployeeId { get; set; }
    public decimal Salary { get; set; }


    public void Work()
    {
        Console.WriteLine($"Employee with ID {EmployeeId} and salary {Salary:C} is working.");
    }
}


public class User : Person
{
    public string Username { get; set; }
    public string Password { get; set; }
    public int Permission { get; set; }


    public void Info()
    {
        Console.WriteLine($"User: {Username} and Password {Password} .");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Employee Employee1 = new Employee();
        Employee1.Name = "John";
        Employee1.Age = 35;
        Employee1.EmployeeId = 123;
        Employee1.Salary = 100000.00M;
        Console.WriteLine("\nEmployee:");
        Employee1.Introduce(); 
        Employee1.Work(); 

        User User1 = new User();
        User1.Name = "Ali";
        User1.Age = 45;
        User1.Username = "User1";
        User1.Password = "1234";


        Console.WriteLine("\nUser:");
        User1.Introduce(); 
        User1.Info(); 


        Console.ReadKey();
    }
}