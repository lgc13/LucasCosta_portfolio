/*******************************************************************************************/
/*      ArraysAndLoops program. Created by Lucas Costa, May 24, 2016                       */
/*  the point of the program is to show animals through different arrays                   */
/*  using for loops, enhanced for loops, while an do while loops                           */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

public class ArraysAndLoops //declared class
{
  public static void main(String[] args)
  {
    //Scanner sc = new Scanner(System.in); //allows user input
    String[] animals = {"dog", "cat", "bird", "fish", "insect"};

    //Code starts here
    System.out.print("Program loops through array of strings.\n");
    System.out.print("Use following values: dog, cat, bird, fish, insect.\n");
    System.out.print("Use following loop structures: for, enhanced for, while, do ...while.\n\n");

    System.out.print("Note: Pretest loops: for, enhanced for, while. Posttest loops: do... while. \n\n");

    System.out.print("for loop:\n");  //for loop
    for(int i = 0; i < 4; i++)
    {
      System.out.print(animals[i] + "\n");
    }

    System.out.println("\nenhanced for loop:"); //enhanced for loop
    for(String loop : animals)
    {
      System.out.print(loop + "\n");
    }

    int count = 0;
    System.out.print("\nwhile loops\n"); //while loops
    while(count < 5)
    {
      System.out.print(animals[count] + "\n");
      count++;
    }
    System.out.print("\n");

    count = 0;
    System.out.print("do while loop:\n"); //do while loop
    do
    {
      System.out.print(animals[count] + "\n");
      count++;
    }while(count < 5);




  }
}
