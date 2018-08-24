/*******************************************************************************************/
/*      fizz-buzz program. Created by Lucas Costa, May 24, 2016                            */
/*  the point of the program is to print out all numbers from 1- 100                       */
/*whenever the number is divisible by 3, print 'fizz', if its divisible by 5, print 'buzz' */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

public class fizz_buzz //declared class
{
  public static void main(String[] args)
  {
    Scanner sc = new Scanner(System.in);

    //Code starts here
    System.out.print("Welcome to Lucas's first ever java program.\n");
    System.out.print("Created by Lucas, most likely with Chris's help\n\n");

    System.out.print("Here, you will see fizz_buzz. Numbers from 1- 100\n");
    System.out.print("Numbers divisible by 3 will be replaced by fizz,\n");
    System.out.print("while those divisible by 5 will be replaced by buzz\n\n");

    for(int i = 1; i <= 100; i++)
    {
      if(i % 3 == 0 && i % 5 == 0)
      {
        System.out.print("buzz & fizz\n");
      }
      else if(i % 3 == 0)
      {
        System.out.print("fizz\n");
      }
      else if(i % 5 == 0)
      {
        System.out.print("buzz\n");
      }
      else
      {
      System.out.print(i + "\n");
      }
    }

  }
}
