namespace OverridingMethod
{
    public class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Print funtcion from clsA/Base Class\n");
        }
    }

    public class clsB : clsA
    {
        public override void Print()
        {
            Console.WriteLine("Print function from clsB/Derived Class\n");
            base.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsB b = new clsB();
            b.Print();

            Console.WriteLine("\n\n");
            
            clsA a = new clsA();
            a.Print();
        }
    }
}