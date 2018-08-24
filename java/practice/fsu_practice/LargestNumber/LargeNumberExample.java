import java.util.Scanner;

public class LargestNumber
{
   public static void main(String[] args)
   {
      Scanner sc = new Scanner(System.in);

         System.out.print("Program evaluates largest of two integers.\n");
         System.out.print("Note: Program does *not* check for non-numeric characters or non-integer values.\n\n");
         System.out.print("Enter first integer: ");
         int num1 = sc.nextInt();
         System.out.print("Enter second integer: ");
         int num2 = sc.nextInt();
         System.out.print("\n");

         if(num1 > num2)
         {
           System.out.println(num1 + " is larger than " + num2 + "\n");
         }
         else if (num2 > num1)
         {
           System.out.println(num2 + " is larger than " + num1 + "\n");
         }
         else
         {
           System.out.println("Integers are equal.\n");
         }

   }
}
