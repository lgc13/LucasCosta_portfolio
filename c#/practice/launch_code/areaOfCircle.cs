using System;

public class areaOfCircle
{
  static public void Main()
  {
    // int radius = 0;
    double pi = Math.PI;
    double thomas_area = 0;

    Console.Write("input a number: ");
    int radius = int.Parse(Console.ReadLine());

    Console.WriteLine("Your number: " + (pi * (radius * radius)));
    thomas_area = FindArea(pi, radius);

    Console.WriteLine("Thomas are is: " + thomas_area);
  }
  public static double FindArea(double pie, int rad)
  {
    return(pie * (rad * rad));
  }
}
