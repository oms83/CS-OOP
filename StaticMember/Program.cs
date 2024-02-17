namespace StaticMember
{
    internal class Program
    {
        class clsA
        {
            public int x = 10;
            public static int y = 20;

            public int Func1()
            {
                return x + y;
            }

            public static int Func2()
            {
                return y    ;
            }
        }

        static void Main(string[] args)
        {
            clsA A = new clsA();
            clsA B = new clsA();

            A.x = 10;
            B.x = 20;
            Console.WriteLine("A.x {0}", A.x);
            Console.WriteLine("A.Func1 {0}", A.Func1());
            Console.WriteLine("A.x {0}", B.x);
            clsA.y = 300;

            Console.WriteLine("A.x {0}", clsA.y);
            Console.WriteLine("A.Func1 {0}", A.Func1());
            Console.WriteLine("Hello, World!");
        }
    }
}