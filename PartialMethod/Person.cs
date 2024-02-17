using System;

public partial class Person
{
    public short Age { get; set; }
    partial void PrintAge();

    public void BirthDay()
    {
        Age++;

        PrintAge();

    }
}