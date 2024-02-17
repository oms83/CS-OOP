namespace SealedClass
{
    public sealed class clsA
    {

    }

    public class clsB
    {
        
    }


    /*
     
        we will take error
     
    
        public class clsC : clsA
        {

        }

     
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}