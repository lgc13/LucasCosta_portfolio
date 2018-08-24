//LargestNumber java program by Lucas Costa. LIS4381, May24, 2016

import java.util.Scanner; //imports all java libraries.

public class LargestNumber //declare class (same name as file)
{
  public static void main(String[] args) //I think this is where you declare an identifier? 'args'?
  {
    Scanner sc = new Scanner(System.in); //what is this line for?

      System.out.print("Program evaluates largest of two integers \n");
      System.out.print("Note: System does not check for non-numeric characters or non integers values. \n");

      System.out.print("Enter the first integer: ");
      int input1 = 0;

      System.out.print("Enter the second interger: ");
      int input2 = sc.nextInt();

      if(input1 > input2)
      {
        System.out.println("\n" + input1 + " is larger than " + input2);
      }
      else if(input2 > input1)
      {
        System.out.println("\n" + input2 + " is larger than " + input1);
      }
      else if(input1 == input2)
      {
        System.out.println("\n" + "Integers are equal. \n");
      }

  }
}
