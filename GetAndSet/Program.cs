namespace GetAndSet
{
    internal class Program
    {
        class clsEmployee
        {
            private string _Name = string.Empty;
            private int _ID;

            public string Name
            {
                get
                { 
                    return _Name; 
                }

                set
                {
                    _Name = value;
                }
            }

            public int ID
            {
                get
                {
                    return _ID;
                }
                
                set 
                { 
                    _ID = value; 
                }
            }

        }
        static void Main(string[] args)
        {
            clsEmployee emp = new clsEmployee();

            emp.Name = "Omer Memes";
            emp.ID = 8320;
            Console.WriteLine("Name: {0},  ID: {1}", emp.Name, emp.ID);
        }
    }
}