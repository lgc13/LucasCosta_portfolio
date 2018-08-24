using System;

public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine("Program requirements");
        Console.WriteLine("  1. Initializa suitable variable(s)");
        Console.WriteLine("  2. Prompt and capture user input");
        Console.WriteLine("  3. Display user input");
        Console.WriteLine("  4. Allow user to press any key to return back to command line");

        Console.Write("\nPlease enter your full name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();

    }
}
