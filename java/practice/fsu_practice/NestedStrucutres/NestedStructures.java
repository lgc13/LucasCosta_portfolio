/*******************************************************************************************/
/*      ArraysAndLoops program. Created by Lucas Costa, June 9, 2016                       */
/*  the point of the program is to                    */
/*                             */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

public class NestedStructures //declared class
{
  public static void main(String[] args)
  {
    Scanner in = new Scanner(System.in); //allows user input
    int[] array = {3, 2, 4, 99, -1, -5, 3, 7};
    int input = 0;

    //Code starts here
    System.out.print("Program searches user entered integer w/in array of integers.\n");
    System.out.print("Create an array with the following values: 3, 2, 4, 99, -1, -5, 3, 7 \n\n");

    System.out.println("Array length: " + array.length);
    System.out.print("Enter search value: ");

    input = in.nextInt();  //user input

    for(int i = 0; i < array.length; i++)
    {
      if(input == array[i])
      {
      System.out.println(input + " found at index " + i);
      }
      else if(input != array[i])
      {
      System.out.println(input + " *not* found at index " + i);
      }
    }




  }
}
