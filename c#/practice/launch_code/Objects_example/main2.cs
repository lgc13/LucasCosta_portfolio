using System;

public class School
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
        Students someone = new Students("Lauren");
        Console.WriteLine("1. Name: " + someone.Name);
        // Console.WriteLine(someone.name); this will not work as name is private

        someone.Name = "David"; // using the "set" from the property

        Console.WriteLine("new name: " + someone.Name);
        Students someone2 = new Students("Thomas");
        Console.WriteLine("2. Name: " + someone2.Name);


        // Console.WriteLine("someone2.name: " + someone2.name);
        // Console.WriteLine("someone2.Name: " + someone2.Name);
    }
}
