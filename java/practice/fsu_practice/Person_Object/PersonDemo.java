/*******************************************************************************************/
/*      PersonDemo program. Created by Lucas Costa, July 7, 2016                       */
/*  the point of the program is to                    */
/*                          */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

class PersonDemo //declared class
{
  public static void main(String[] args)
  {
    //variables
    Scanner sc = new Scanner(System.in); //allows user input
    String fn = "";
    String ln= "";
    int y = 0;

    System.out.println("\n///Below are default constructor values///");

    Person v1 = new Person(); //created default object
    System.out.println("fname: " + v1.getFname());
    System.out.println("lname: " + v1.getLname());
    System.out.println("age: " + v1.getAge());

    System.out.println("\n///Below are user entered values///"); //ask for user input, set it to Person objects
    System.out.print("\nfname: ");
    fn = sc.nextLine();
    System.out.print("lname: ");
    ln = sc.nextLine();
    System.out.print("age: ");
    y = sc.nextInt();
    System.out.println();

    Person v2 = new Person(fn, ln, y); //Put out 'Person' with user inputted info, w/ get'name'
    System.out.println("fname: " + v2.getFname());
    System.out.println("lname: " + v2.getLname());
    System.out.println("age: " + v2.getAge());

    System.out.println("\n///Below using setter methods to pass literal values, then print() method to display values///");
    v2.setFname("Lucas");  //user set'info' to put in literal values on names, ages
    v2.setLname("Costa");
    v2.setAge(22);
    v2.print();           //output 'print' from Person, with input values from above
  }
}
