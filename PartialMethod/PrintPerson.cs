using System;

public partial class Person
{
    partial void PrintAge()
    {
        Console.WriteLine("person age is : {0}", Age);
    }
}