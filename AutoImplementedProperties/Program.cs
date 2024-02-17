using System;
namespace AutoImplementedProperties
{
        internal class Program
        {
            class clsEmployee
            {
               
                public string Name
                {
                    get;
                    set;
                }

                public int ID
                {
                    get;
                    set;
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