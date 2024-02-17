namespace AbstractClass
{
    public abstract class clsPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void Introduce();

        public void SayGoodBye()
        {
            Console.WriteLine("Good Bye");
        }

    }
    public class clsEmployee : clsPerson
    {
        public int EmployeeID { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} {Surname}, and my employee id is {EmployeeID}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //clsPerson Person = new clsPerson();
            clsEmployee Employee = new clsEmployee();
            Employee.Name = "Omer";
            Employee.Surname = "MEMES";
            Employee.EmployeeID = 8320;
            Employee.SayGoodBye();
            Employee.Introduce();
        }
    }
}