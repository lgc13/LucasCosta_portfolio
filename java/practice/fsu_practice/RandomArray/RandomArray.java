/*******************************************************************************************/
/*      RandomArray program. Created by Lucas Costa on June 14, 2016                       */
/*  the point of the program is to use for, enhanced for, while, and do while loops        */
/*  to print out an 'input' amount of random numbers using pseudo randomizer               */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries
import java.util.Random;  //import pseudo random generator library

public class RandomArray //declared class
{
  public static void main(String[] args)
  {
    int input = 0;
    Scanner in = new Scanner(System.in); //allows user input
    Random generator = new Random();  //declare pseudo randomizer

    //Code starts here
    System.out.print("Program prompts user to enter desired number of pseudorandom-generated integers (min 1).\n");
    System.out.println("Use following loop structures: for, enhanced for, while, do ...while.\n");

    System.out.print("Enter desired number of pseudorandom-generated integers (min 1): ");
    input = in.nextInt();  //takes user input

    int array[] = new int[input];     // declares array, dynamically allocates it to size 'input'

    System.out.println("\nfor loop:");  //for loop
    for(int i = 0; i < input; i++)
    {
      array[i] = generator.nextInt();
      System.out.println("Generated: " + array[i]);
    }

    System.out.println("\nenhanced for loop:"); //enhanced for loop
    for(int array2 : array)
    {
      System.out.println("Generated: " + array2);
    }

    int count = 0;
    System.out.println("\nwhile loops"); //while loops
    while(count < input)
    {
      System.out.println("Generated: " + array[count]);
      count++;
    }
    System.out.print("\n");

    count = 0;
    System.out.print("do while loop:\n"); //do while loop
    do
    {
      System.out.println("Generated: " + array[count]);
      count++;
    }while(count < input);

  }
}
