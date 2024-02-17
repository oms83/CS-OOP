namespace Composition
{
    
    public class clsA
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Function1()
        {
            Console.WriteLine("this is function 1");
        }

        public void Function2()
        {
            Console.WriteLine("this is function 1");
        }

        public void Function3()
        {
            Console.WriteLine("this is function 1");
        }

        public void Function4()
        {
            Console.WriteLine("this is function 1");
        }

    }
    
    public class clsB
    {
        public clsA A = new clsA();

        public void Function5()
        {
            Console.WriteLine("this is function 1");
        }

        public void Function6()
        {
            Console.WriteLine("function 1 in class clsA from function 6 in class clsB");
            A.Function1();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsB B = new clsB();

            B.Function6();

            B.A.Function2();
        }
    }
}