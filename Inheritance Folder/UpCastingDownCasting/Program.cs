using System;

namespace UpCastingDownCasting
{
    public class clsPerson
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public clsPerson(string Name, int Id) 
        {
            this.Name = Name;
            this.Id = Id;
        }
        public void Greet()
        {
            Console.WriteLine("Hello my name is {0} my id is {1}", this.Name, this.Id);
        }

    };

    public class clsEmpolyee : clsPerson
    {
        public string Company { get; set; }
        public double Salary { get; set; }

        public clsEmpolyee(string Company, double Salary, string Name, int Id) : base(Name, Id)
        {
            this.Company = Company;
            this.Salary = Salary;

        }

        public void Work()
        {
            Console.WriteLine($"I am work at {Company} and earn {Salary:C} per year");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // UpCating
            clsEmpolyee empolyee1 = new clsEmpolyee("Oms", 12000, "Omer", 8320);
            clsPerson Person1 = empolyee1;

            Console.WriteLine(empolyee1.Name);
            Console.WriteLine(empolyee1.Id);
            Person1.Greet();

            // DownCating
            clsPerson Person = new clsEmpolyee("Oms", 11000, "ALi", 8520);
            
            //clsPerson Person = new clsEmpolyee { Company = "Oms", Salary = 11000, Name = "ALi", Id = 8520 };

            clsEmpolyee employee2 = (clsEmpolyee)Person;
            employee2.Work();

            
            // Wrong
            /*
            
                clsEmpolyee Employee3 = new clsPerson("Yusuf", 8632);

                clsPerson Person3 = new clsPerson("Yusuf", 8632);
                clsEmpolyee Employee3 = (clsEmpolyee)Person3;
                Employee3.Work();

            */
        }
    }
}