
public class clsA
{
    public virtual void MyMethod()
    {
        Console.WriteLine("My Method From Base Class");
    }
    public virtual void MyOtherMethod()
    {
        Console.WriteLine("My Other Method From Base Class");
    }
}

public class clsB : clsA
{
    public override void MyMethod()
    {
        Console.WriteLine("My Method From Derived Class");
    }

    public new void MyOtherMethod()
    {
        Console.WriteLine("My Other Method From Derived Class");
    }
}


namespace ShodowingOrHidingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nFrom Base Class\n");

            clsA A  = new clsA();
            A.MyMethod();
            A.MyOtherMethod();


            Console.WriteLine("\n\nFrom Derived Class\n");

            clsB B = new clsB();
            B.MyMethod();
            B.MyOtherMethod();


            Console.WriteLine("\n\nWith Up Casting\n");

            clsA AA = new clsB();
            AA.MyMethod();  
            AA.MyOtherMethod();
        }
    }
}