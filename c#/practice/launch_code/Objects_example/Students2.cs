using System;

public class Students
{
    public string name;
    public string Name {
        get {
            return name;
        }
        set {
            name = value;
        }
    }

    public string Name { get; set;}

    public Students(string name)
    {
        Console.WriteLine("Default constructor for Students2.cs");
        Name = name;
    }

    // public string getName()  // not needed
    // {
    //     Console.WriteLine("getting the name...");
    //     return name;
    // }
    //
    // public void setName(string n)
    // {
    //     this.name = n;
    // }
}
