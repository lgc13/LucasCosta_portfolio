import java.util.Scanner;
import java.util.Random;

public class Methods
{
   public static void main(String[] args)
   {
      Scanner sc = new Scanner(System.in);

      heading();

      int size = sc.nextInt();

      int[] list = generateArray(size);

      printArray(list, size);

      return;
   }

   public static void heading()
   {
      System.out.print("Program promps user to enter desired number of pseudorandom-generated integers (min 1).\n");
      System.out.println("Use following loop structures: for, enhanced for, while, do...while.");
      System.out.println("Create *and* display the values *at least* one value-returning method, and one void method.\n");
      System.out.print("Enter desired number of pseudorandom-generated integers (min 1): ");

      return;
   }

   public static int[] generateArray(int num)
   {
     Random generator = new Random();

     int[] list = new int[num];

     for(int i = 0; i < num; i++)
     {
       list[i] = generator.nextInt();
     }

     return list;
   }

   public static void printArray(int[] list, int size)
   {

     System.out.println("\nfor loop:");
     for(int i = 0; i < size; i++)
     {
       System.out.println("Generated: " + list[i]);
     }
     System.out.println(" ");

     System.out.println("enhanced for loop:");
     for(int list2 : list)
     {
       System.out.println("Generated: " + list2);
     }
     System.out.println(" ");

     int count = 0;
     System.out.println("while loops");
     while(count < size)
     {
       System.out.println("Generated: " + list[count]);
       count++;
     }
     System.out.println(" ");

     count = 0;
     System.out.println("do while loop:");
     do
     {
       System.out.println("Generated: " + list[count]);
       count++;
     } while(count < size);
     System.out.println(" ");
   }
}
