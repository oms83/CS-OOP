namespace MultipleConstructorsUsingOverloading
{
    internal class Program
    {
        class clsPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public short Age { get; set; }

            public clsPerson() 
            {
                Id = 8320;
                Name = "Omer Memes";
                Age = 23;
            }

            public clsPerson(int Id, string Name, short Age)
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
            }

        }
        static void Main(string[] args)
        {
            clsPerson Per1 = new clsPerson();
            
            clsPerson Per2 = new clsPerson(8322, "Ali MEMES", 22);

            Console.WriteLine("Name: {0}, ID: {1}, Age: {2}", Per1.Name, Per1.Id, Per1.Age);
            Console.WriteLine("Name: {0}, ID: {1}, Age: {2}", Per2.Name, Per2.Id, Per2.Age);
        }
    }
}