/*******************************************************************************************/
/*      PersonDemo program. Created by Lucas Costa, July 7, 2016                       */
/*  the point of the program is to                    */
/*                          */
/*******************************************************************************************/

import java.util.Scanner; //imports all libraries

class EmployeeDemo //declared class
{
  public static void main(String[] args)
  {
    //variables
    Scanner sc = new Scanner(System.in); //allows user input
    String fn = "";
    String ln= "";
    int y = 0;
    int s = 123012380;
    char g = 'Y';

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

    System.out.println();

    System.out.print("\n///Below are derived class default constructor values:///");
    Employee e1 = new Employee(fn, ln, y, s, g);
    System.out.println("\nFname: " + e1.getFname());
    System.out.println("Lname: " + e1.getLname());
    System.out.println("Age: " + e1.getAge());
    System.out.println("SSN: " + e1.getSsn());
    System.out.println("Gender: " + e1.getGender());

    System.out.println("\nOr...");
    e1.print();

    System.out.println("\n///Below are derived class user entered values///");

    System.out.print("\nFname: ");
    fn = sc.next();

    System.out.print("Lname: ");
    ln = sc.next();

    System.out.print("Age: ");
    y = sc.nextInt();

    System.out.print("SSN: ");
    s =sc.nextInt();

    System.out.print("Gender: ");
    g = sc.next().charAt(0);

    Employee e2 = new Employee(fn, ln, y, s, g);
    System.out.println("\nFname: " + e2.getFname());
    System.out.println("Lname: " + e2.getLname());
    System.out.println("Age: " + e2.getAge());
    System.out.println("SSN: " + e2.getSsn());
    System.out.println("Gender: " + e2.getGender());
  }
}
