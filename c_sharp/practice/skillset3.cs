using System;

public class skillset3
{
    static public void Main ()
    {
        DateTime dat = DateTime.Now;
        Decimal bill = 100.00m;
        Console.WriteLine(bill.ToString("G2"));
        //String.Format( "{0,0}", Math.Round(amount, 2));
      //  System.Math.Round(bill, 2);

        Console.WriteLine("Program Requirements: ");
        Console.WriteLine("  1) Use instrinsic method to display date/time ");
        Console.WriteLine("  2) Use two types of selection structures: if...else if...else, and switch");
        Console.WriteLine("  3) Initialize suitable variable(s): use decimal data type for bill");
        Console.WriteLine("  4) Prompt and capture user input");
        Console.WriteLine("  5) Display money in currency format");
        Console.WriteLine("  6) Allow user to press any key to return back to command line");

        Console.WriteLine("\nNow: {0:d}, {0:T} ", dat);

        Console.WriteLine("\n*** if...else if ...else example ***");
        Console.WriteLine("Your bill is $" + bill);

        Console.WriteLine("\nDiscounts:");
        Console.WriteLine("6+:  30% off");
        Console.WriteLine("3-5: 20% off");
        Console.WriteLine("2:   10% off");
        Console.WriteLine("1:   Regular price");

        Console.Write("\nHow many books did you buy? ");
        Decimal input = Decimal.Parse(Console.ReadLine());
        Console.Write("Your total is: $");

        Decimal d2 = 0.10m;
        Decimal d3 = 0.20m;
        Decimal d6 = 0.30m;

        if (input == 1)
        {
          Console.WriteLine(bill);
        }
        else if (input == 2)
        {
          Console.WriteLine(bill - (bill * d2));
        }
        else if (input >= 3 && input <= 5)
        {
          Console.WriteLine(bill - (bill * d3));
        }
        else if (input >= 6)
        {
          Console.WriteLine(bill - (bill * d6));
        }

        Console.WriteLine("*** Switch example ***");

        Console.WriteLine("\n1- red");
        Console.WriteLine("2- green");
        Console.WriteLine("3- blue");

        Console.Write("\nWhat is your favorite color? ");
        int input2 = Int32.Parse(Console.ReadLine());
        Console.Write("Your favorite color is ");

        switch(input2)
        {
          case 1:
          Console.WriteLine("red!");
          break;
          case 2:
          Console.WriteLine("green!");
          break;
          case 3:
          Console.WriteLine("blue!");
          break;
        }

        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();

    }
}
