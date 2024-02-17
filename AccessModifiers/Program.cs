using System;
using System.Runtime.CompilerServices;

namespace AccessModifiers
{
    class clsA
    {
        public int x1=20;
        private int x2=30;
        protected int x3=40;

        public int func1()
        {
            return 100;
        }

        private int func2()
        {
            return 200;
        }

        protected int func3()
        {
            return 300;
        }

    }
    class clsB : clsA
    {
        public int fun4()
        {
            return x1 + x3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();    
            A.x1 = 1;
            Console.WriteLine("func1 {0}", A.func1());
            Console.WriteLine("func4 {0}", A.x1);

            clsB B = new clsB();
            Console.WriteLine("func4 {0}", B.fun4());
            Console.WriteLine("func4 {0}", B.x1);

            Console.ReadKey();
        }
    }
}