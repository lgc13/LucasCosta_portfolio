using System;

public class calculator
{
  static public void Main()
  {
    DateTime dat = DateTime.Now;
    double number1, number2;
    int choice1 = 0;
    bool validInput = false;

    Console.WriteLine("**********************************");
    Console.WriteLine("*     A2: Simple calculator      *");
    Console.WriteLine("*  Arthor: Lucas Costa           *");
    Console.WriteLine("*  Now: {0:d}, {0:T}    *", dat);       //display current date and time
    Console.WriteLine("**********************************");

    Console.Write("\nNum1: ");
    number1 = Double.Parse(Console.ReadLine());
    Console.Write("Num2: ");
    number2 = Double.Parse(Console.ReadLine());

    Console.WriteLine("\n1- Addition");
    Console.WriteLine("2- Subtraction");
    Console.WriteLine("3- Multiplication");
    Console.WriteLine("4- Division");

    Console.Write("\nChoose a mathmatical operation: ");
    while (!validInput)  //check user input to make sure a number is put between 1 - 4
    {
      choice1 = Int32.Parse(Console.ReadLine());
      validInput = true;

      switch(choice1)
      {
      case 1:
        Console.WriteLine("Choice: " + choice1 + "- Addition");
        Console.WriteLine("*** Result of addition operation: ***");
        Console.WriteLine(number1 + number2);
        break;
      case 2:
        Console.WriteLine("Choice: " + choice1 + "- Subtraction");
        Console.WriteLine("*** Result aof subtracion operation: ***");
        Console.WriteLine(number1 - number2);
        break;
      case 3:
        Console.WriteLine("Choice: " + choice1 + "- Multiplication");
        Console.WriteLine("*** Result of Multiplication operation: ***");
        Console.WriteLine(number1 * number2);
        break;
      case 4:
        Console.WriteLine("Choice: " + choice1 + "- Division");
        Console.WriteLine("*** Result of division operation: ***");
        if (number2 == 0)
        {
          Console.WriteLine("Division by 0 is not allowed"); //can't divide by 0, DUHHH
        }
        else
        {
          Console.WriteLine(number1 / number2);
        }
        break;
      default:
        Console.Write("Invalid input. Please enter a number from 1 to 4: ");
        validInput = false;  //validInput is true, so it must run again
        break;
      }
    }

    Console.WriteLine("\nPress any key to exit");
    Console.ReadKey();


    /*
    while (checker == 1)  //trying to make them choose a value between 1 - 4
    {
      choice1 = Decimal.Parse(Console.ReadLine());
      Console.Write("Invalid input. Please input a number from 1 to 4: ");
      return 0;
    }
    */


    /*
    Console.WriteLine();
    if (choice1 == 1)           //if statement to act as a switch
    {
      Console.WriteLine("Choice: " + choice1 + "- Addition");
      Console.WriteLine("*** Result of addition operation: ***");
      Console.WriteLine(number1 + number2);
    }
    else if (choice1 == 2)
    {
      Console.WriteLine("Choice: " + choice1 + "- Subtraction");
      Console.WriteLine("*** Result of subtracion operation: ***");
      Console.WriteLine(number1 - number2);
    }
    else if (choice1 == 3)
    {
      Console.WriteLine("Choice: " + choice1 + "- Multiplication");
      Console.WriteLine("*** Result of Multiplication operation: ***");
      Console.WriteLine(number1 * number2);
    }
    else if (choice1 == 4)
    {
      Console.WriteLine("Choice: " + choice1 + "- Division");
      Console.WriteLine("*** Result of division operation: ***");
      Console.WriteLine(number1 / number2);
    }
    else
    {
      Console.WriteLine("Please choose a number between 1 - 4");
    }
    */


 //Apparently c# doesnt read in doubles in switches..that sucks. But you can use an integer

  }
}
