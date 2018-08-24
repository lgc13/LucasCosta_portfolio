import java.util.Scanner;

public class EvenOrOdd
{
   public static void main(String[] args)
   {
      Scanner sc = new Scanner(System.in);

         System.out.print("This program will check whether the number is even or odd.\n");
         System.out.print("Note: The program doesn't check the type of number input.\n\n\n");
         System.out.print("Enter a number:   ");
         int input = sc.nextInt();

         if(input % 2 == 0)
         {
           System.out.println("\n" + userNumber + " is an even number.\n");
         }

         else
         {
           System.out.println("\n" + userNumber + "\n is an odd number.\n");
         }

   } //end of main

} // end of class
