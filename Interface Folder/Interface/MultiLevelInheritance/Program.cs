namespace MultiLevelInheritance
{
    public class clsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Interduce()
        {
            Console.WriteLine($"Hi, My name is {Name} and i'am {Age} years old.");
        }
    }

    public class clsEmployee:clsPerson
    {
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"Employee with ID {EmployeeID} and  Salary {Salary:C} is working");
        }
    }

    public class clsDoctor : clsEmployee
    {
        public string Specialty { get; set; }

        public void Heal()
        {
            Console.WriteLine($"Doctor {Name} with ID {EmployeeID}, salary {Salary:C} and specailty {Specialty}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsDoctor doctor = new clsDoctor();

            doctor.Name = "Ali";
            doctor.Age = 44;
            doctor.Specialty = "doctor";
            doctor.EmployeeID = 5656;
            doctor.Salary = 10000.00M;

            doctor.Work();
        }
    }
}