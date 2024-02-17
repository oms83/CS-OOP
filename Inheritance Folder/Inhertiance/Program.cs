namespace Inhertiance
{
    public class clsPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Phone { get; set; }

        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }

        public clsPerson(string Name, string Surname, string Phone)
        {
            this.Name = Name;
            this.Surname = Surname; 
            this.Phone = Phone;
        }
    }
    public class clsEmployee : clsPerson
    {
        public string Address { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }

        public void IncreaseSalaryBy(double Amount)
        {
            Salary += Amount;
        }

        public clsEmployee(string Name, string Surname, string Phone, string Depatment, string Address, double Salary) : base(Name, Surname, Phone)
        {
            this.Address = Address;
            this.Salary = Salary;
            this.Department = Depatment;
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee employee = new clsEmployee("Ali", "MEMES", "05510461244", "Student", "Hatay", 10000);
                
            Console.WriteLine("Full Name  : {0}", employee.FullName);
            Console.WriteLine("Phone      : {0}", employee.Phone);
            Console.WriteLine("Department : {0}", employee.Department);
            Console.WriteLine("Salary     : {0}", employee.Salary);
            Console.WriteLine("Address    : {0}\n\n", employee.Address);
                
            employee.Name = "Omer"; 
            employee.Surname = "MEMES";
            employee.Salary = 12000;
            employee.Address = "Elazig";
            employee.Department = "Software Engineer";
            employee.Phone = "05398914803";

            Console.WriteLine("Full Name  : {0}", employee.FullName);
            Console.WriteLine("Phone      : {0}", employee.Phone);
            Console.WriteLine("Department : {0}", employee.Department);
            Console.WriteLine("Salary     : {0}", employee.Salary);
            Console.WriteLine("Address    : {0}", employee.Address);
        }


    }

}
