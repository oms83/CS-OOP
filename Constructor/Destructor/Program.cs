namespace Destructor
{   
    class clsA
    {
        public clsA() 
        {
            Console.WriteLine("Hi i am constructor function :-) ");
        }

        ~clsA()
        {
            Console.WriteLine("Hi i am constructor function: -) ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();
            
        }
    }
}