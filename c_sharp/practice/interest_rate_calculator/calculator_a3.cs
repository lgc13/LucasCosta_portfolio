using System;

public class calculator
{
  static public void Main()
  {
    DateTime dat = DateTime.Now;
    decimal presentValue = 0.0m;   //starting balance
    int numYears = 0;          //years
    decimal yearlyInt = 0.0m;  //interest rate
    decimal monthlyDep = 0.0m;   //monthly deposit

    Console.WriteLine("**********************************");
    Console.WriteLine("     A3: Future value calculator      ");
    Console.WriteLine("  Arthor: Lucas Costa           ");
    Console.WriteLine("  1) Use intrinsic method to display date/time ");
    Console.WriteLine("  2) Research what is future value? And, its formula");
    Console.WriteLine("  3) Create FutureValue method using the following paremeters: decimal presentValue, int numYears, decimal yearlyInt, decimal monthlyDep  ");
    Console.WriteLine("  4) Initialize suitable variable(s): use decimal data types for currency variables");
    Console.WriteLine("  5) Perform data validation: prompt user until correct data is entered");
    Console.WriteLine("  6) Display money in currency format");
    Console.WriteLine("  7) Allow user to press any key to return back to command line");
    Console.WriteLine("**********************************");

    Console.WriteLine("*  Now: {0:d}, {0:T}    *", dat);       //display current date and time

    Console.Write("\nStarting balance: ");
    while(!Decimal.TryParse(Console.ReadLine(), out presentValue))
    {
      Console.WriteLine("Starting balance must be numeric.");
      Console.Write("Starting balance: ");
    }

    Console.Write("\nTerm in years: ");
    while(!int.TryParse(Console.ReadLine(), out numYears))
    {
      Console.WriteLine("Term must be integer data type.");
      Console.Write("Term in years: ");
    }

    Console.Write("\nInterest Rate: ");
    while (!Decimal.TryParse(Console.ReadLine(), out yearlyInt))
    {
      Console.WriteLine("Interet rate must be numeric.");
      Console.Write("First int. rate: ");
    }

    Console.Write("\nMonthly deposit: ");
    while (!Decimal.TryParse(Console.ReadLine(), out monthlyDep))
    {
      Console.WriteLine("Monthly deposit must be numeric.");
      Console.Write("Monthly deposit: ");
    }

    Console.WriteLine("\n*** Future Value ***");
    decimal finalValue = FutureValue(presentValue, numYears, yearlyInt, monthlyDep);
    Console.WriteLine(finalValue.ToString("C2")); //display two decimal points

    Console.WriteLine("\nPress any key to exit");
    Console.ReadKey();

  }
  //FutureValue method
  public static decimal FutureValue(decimal presentValue, int numYears, decimal yearlyInt, decimal monthlyDep)
  {
    int numMonths = numYears * 12;
    double monthlyInt = (double)yearlyInt/12/100;

    return presentValue * (decimal)Math.Pow((1 + monthlyInt), numMonths) + (monthlyDep * (decimal)(Math.Pow((1 + monthlyInt), numMonths) - 1)/(decimal)(monthlyInt));
  }

}
