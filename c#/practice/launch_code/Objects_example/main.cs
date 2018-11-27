using System;

public class School
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
        Student someone = new Student();

        Console.WriteLine("1. Name: " + someone.getName());
        // Console.WriteLine(someone.name); this will not work as name is private

        someone.setName("Scott");
        Console.WriteLine("2. Name: " + someone.getName());

        Student someone2 = new Student("David");
        Console.WriteLine("3. someone2 name: " + someone2.getName());
        
    }
}
