using System;
namespace RealLifeApplicationOfUsingStaticAndConstructors
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public clsPerson(string Name, int Id, int Age)
        {
            this.Name = Name;
            this.Id = Id;
            this.Age = Age;
        }

        public static clsPerson Find(int Id)
        {
            if(Id == 8320)
            {
                return new clsPerson("Omer", 8320, 23);
            }
            else
            {
                return null;
            }
        }
        public static clsPerson Find(string Username, string Password)
        {
            if (Username == "oms83" && Password == "8320")
            {
                return new clsPerson("Omer MEMES", 8320, 23);
            }
            else
            {
                return null;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person = clsPerson.Find(8320);

            if(Person != null)
            {
                Console.WriteLine("Name: {0}", Person.Name);
                Console.WriteLine("Id: {0}", Person.Id);
                Console.WriteLine("Age: {0}", Person.Age);
            }
            else
            {
                Console.WriteLine("Could not fint the person with given ID");
            }

            clsPerson Person2 = clsPerson.Find("oms83", "8320");

            if (Person2 != null)
            {
                Console.WriteLine("Name: {0}", Person2.Name);
                Console.WriteLine("Id: {0}", Person2.Id);
                Console.WriteLine("Age: {0}", Person2.Age);
            }
            else
            {
                Console.WriteLine("Could not fint the person with given Username and Password");
            }


            clsPerson Person3 = clsPerson.Find("oms83", "83");

            if (Person3 != null)
            {
                Console.WriteLine("Name: {0}", Person3.Name);
                Console.WriteLine("Id: {0}", Person3.Id);
                Console.WriteLine("Age: {0}", Person3.Age);
            }
            else
            {
                Console.WriteLine("Could not fint the person with given Username and Password");
            }

        }
    }
}