using System;

public class temperature_change
{
    static public void Main ()
    {
        Console.Write("Fahreheit temperature: ");
        double x = Double.Parse(Console.ReadLine());
        Console.WriteLine( x + "°F = " + ((x - 32)*(5.0/9.0)) + "°C");

        Console.Write("Celcius temperature: ");
        double y = Double.Parse(Console.ReadLine());
        Console.WriteLine(y + "°C = " + ((y * (9.0/5.0)) + 32) + "°F");

    }
}
