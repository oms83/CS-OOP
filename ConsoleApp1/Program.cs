using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalssLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMyMath m = new clsMyMath();
            Console.WriteLine(m.Sum(1, 3, 4));
            Console.WriteLine(m.Sum(4, 3, 4));
                
            Console.ReadKey();


        }
    }
}
