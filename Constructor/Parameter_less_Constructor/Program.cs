namespace Parameter_less_Constructor
{
    internal class Program
    {
        class clsPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public clsPerson() 
            {
                Id = 1;
                Name = "omer";
            }
        }
        static void Main(string[] args)
        {
            clsPerson p = new clsPerson();
            
            Console.WriteLine("Name: {0}, Id: {1}", p.Name, p.Id);
        }
    }
}