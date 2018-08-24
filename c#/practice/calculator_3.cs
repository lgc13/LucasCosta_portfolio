using System;

public class mainFunction
{
  static public void Main()
  {
    DateTime dat = DateTime.Now;
    double number1, number2;
    int choice1 = 0;

    Console.WriteLine("**********************************");
    Console.WriteLine("*     Quiz 5 - Calculator 2.0    *");
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
    Console.WriteLine("5- Exponentiation");

    Console.Write("\nChoose a mathmatical operation: ");
    bool validInput = false;

    while (!validInput)  //check user input to make sure a number is put between 1 - 5
    {
      choice1 = Int32.Parse(Console.ReadLine());
      validInput = true;

      switch(choice1)
      {
      case 1:
        double result1 = Add(choice1, number1, number2);
        Console.WriteLine(result1);
        break;
      case 2:
        double result2 = Subtract(choice1, number1, number2);
        Console.WriteLine(result2);
        break;
      case 3:
        double result3 = Multiply(choice1, number1, number2);
        Console.WriteLine(result3);
        break;
      case 4:
        double result4 = Divide(choice1, number1, number2);
        Console.WriteLine(result4);
        break;
      case 5:
        double result5 = Exponentiate(choice1, number1, number2);
        Console.WriteLine(result5);
        break;
      default:
        Console.Write("Invalid input. Please enter a number from 1 to 5: ");
        validInput = false;  //validInput is true, so it must run again
        break;
      }
    }

    Console.WriteLine("\nPress any key to exit");
    Console.ReadKey();

  }
  static double Add(int choice1, double number1, double number2)
  {
    Console.WriteLine("Choice: " + choice1 + "- Addition");
    Console.WriteLine("*** Result of addition operation: ***");
    double result1 = (number1 + number2);
    return result1;
  }
  static double Subtract(int choice1, double number1, double number2)
  {
    Console.WriteLine("Choice: " + choice1 + "- Subtraction");
    Console.WriteLine("*** Result aof subtracion operation: ***");
    double result2 = (number1 - number2);
    return result2;
  }
  static double Multiply(int choice1, double number1, double number2)
  {
    Console.WriteLine("Choice: " + choice1 + "- Multiplication");
    Console.WriteLine("*** Result of Multiplication operation: ***");
    double result3 = (number1 * number2);
    return result3;
  }
  static double Divide(int choice1, double number1, double number2)
  {
    double result4 = 0.0;
    Console.WriteLine("Choice: " + choice1 + "- Division");
    Console.WriteLine("*** Result of division operation: ***");
    if (number2 == 0)
    {
      Console.WriteLine("Division by 0 is not allowed"); //can't divide by 0, DUHHH
    }
    else
    {
      result4 = (number1 / number2);
    }
    return result4;
  }
  static double Exponentiate(int choice1, double number1, double number2)
  {
    Console.WriteLine("Choice: " + choice1 + "- Exponentiation");
    Console.WriteLine("*** Result of exponential operation: ***");
    double result5 = (Math.Pow(number1, number2));
    return result5;
  }
}
