namespace NestedClass
{
    public class clsOuter
    {
        public int OuterVariable { get; set; }

        public clsOuter(int outerVariable)
        {
            this.OuterVariable = outerVariable;
        }

        public void OuterMethod()
        {
            Console.WriteLine("this is outer method");
        }

        public class  clsInner
        {
            public int InnerVariable { get; set; }
            
            public clsInner(int innerVariable)
            {
                this.InnerVariable = innerVariable;
            }
            public void InnerMethod()
            {
                Console.WriteLine("this is inner method");
            }

            public void AccessToOuterVariable(clsOuter outer)
            {
                Console.WriteLine("Outer Variable from inner class : {0}", outer.OuterVariable);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsOuter outer = new clsOuter(500);
            outer.OuterMethod();
            Console.WriteLine("outer variable {0}", outer.OuterVariable);

            clsOuter.clsInner inner = new clsOuter.clsInner(100);

            inner.InnerMethod();
            inner.AccessToOuterVariable(outer);
            Console.WriteLine("inner variable from inner class : {0}", inner.InnerVariable);

        }
    }
}