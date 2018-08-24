/*******************************************************************************************/
/*      DecisionStructures program. Created by Lucas Costa, May 31, 2016                   */
/*  the point of the program is to use if statements and switch statements to              */
/*  take user input and output what kind of phone they have                                */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

public class DecisionStructures //declared class
{
  public static void main(String[] args)  // main function
  {
    Scanner in = new Scanner(System.in); // allows user input

    String input; //declaring input variable

    System.out.println("\nProgram evaluates user-entered characters.");
    System.out.println("Use the following characters: W or w, C or c, H or h, N or n.");
    System.out.println("Use following decision structures: if...else, and switch.\n");

    System.out.println("Phone types: W or w (work), C or c (cell), H or h (home), N or n (none).");
    System.out.print("Enter phone type: ");
    input = in.nextLine();                   //asks for user input

    System.out.println("\nif...else");
    System.out.print("Phone type: ");

    if(input.equals("W") || input.equals("w"))  //if statement begins here
    {
      System.out.println("work");
    }
    else if(input.equals("C") || input.equals("c"))
    {
      System.out.println("cell");
    }
    else if(input.equals("H") || input.equals("h"))
    {
      System.out.println("home");
    }
    else if(input.equals("N") || input.equals("n"))
    {
      System.out.println("none");
    }
    else                               //inproper input
    {
      System.out.println("Incorrect character entry");
    }

    System.out.println("\nswitch:");
    System.out.print("Phone Type: ");
    switch(input)
    {
      case "W": System.out.println("work");
                break;
      case "w": System.out.println("work");
                break;
      case "C": System.out.println("cell");
                break;
      case "c": System.out.println("cell");
                break;
      case "H": System.out.println("home");
                break;
      case "h": System.out.println("home");
                break;
      case "N": System.out.println("none");
                break;
      case "n": System.out.println("none");
                break;
      default: System.out.println("Incorrect character entry");
                break;
    }

  }

}
