namespace Parameterized_Constructor
{
    internal class Program
    {
        class clsPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public clsPerson(int Id, string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }
        }
        static void Main(string[] args)
        {
            //clsPerson p = new clsPerson();    Error 
            clsPerson p = new clsPerson(8320, "Omer MEMES"); 

            Console.WriteLine("Name: {0}, Id: {1}", p.Name, p.Id);
        }
    }
}