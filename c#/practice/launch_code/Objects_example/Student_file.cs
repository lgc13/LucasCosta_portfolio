using System;

public class Student
{
    private string name; // this doesn't set the name to lucas at all

    public Student() // default constructor
    {
        Console.WriteLine("Default constructor for Student.cs");
        name = "some default value";
    }

    public Student(string some_name)
    {
        name = some_name;
    }

    public string getName()
    {
        Console.WriteLine("getting the name...");
        return name;
    }

    public void setName(string n)
    {
        this.name = n;
    }

}
