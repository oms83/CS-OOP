namespace DefaultConstructor
{
    internal class Program
    {
        class clsPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
        static void Main(string[] args)
        {
            //clsPerson p = new clsPerson();    Error 
            clsPerson p = new clsPerson();

            p.Name = "Omer MEMES";
            p.Id = 8320;

            Console.WriteLine("Name: {0}, Id: {1}", p.Name, p.Id);
        }
    }
}