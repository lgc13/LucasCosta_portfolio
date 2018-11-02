using System;

public class Loops
{
  static public void Main()
  {
    DateTime dat = DateTime.Now;
    
    Console.WriteLine("Program Requirements:");
    Console.WriteLine("1- Use intrinsic method to display date/time");
    Console.WriteLine("2- Use four types of iteration structures: for, while, do... while, for each ");
    Console.WriteLine("3- Initialize suitable variable(s)");
    Console.WriteLine("4- Loop through numbers 1 - 10");
    Console.WriteLine("5- Create string array (for days of the week)");
    Console.WriteLine("6- Use foreach iteration structure to loop through days of the week");
    Console.WriteLine("7- Allow user to press any key to return to command line");

    Console.WriteLine("\nNow: {0:d}, {0:T} ", dat);

    Console.WriteLine("\n* For Loop:"); //for loop
    for (int i = 0; i < 10; i++)
    {
      Console.Write(i + 1 + " ");
    }
    Console.WriteLine("");

    int j = 0;
    Console.WriteLine("\n* While Loop:"); //while loop
    while (j < 10)
    {
      Console.Write((j + 1) + " ");
      j++;
    }
    Console.WriteLine("");

    Console.WriteLine("\n* Do... while loop:");  //do... while loop
    int x = 0;
    do
    {
      Console.Write((x + 1) + " ");
      x++;
    }while(x < 10);
    Console.WriteLine("");

    Console.WriteLine("\n* For each loop:");  //for each loop
    string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    foreach (string value in weekDays)
    {
      Console.Write(value + ", ");
    }
    Console.WriteLine("");











  }
}
