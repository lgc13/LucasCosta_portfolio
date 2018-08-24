/*******************************************************************************************/
/*      PersonDemo program. Created by Lucas Costa, July 7, 2016                       */
/*  the point of the program is to                    */
/*                          */
/*******************************************************************************************/

using System; //imports all libraries
namespace personClass
{
  class PersonDemo //declared class
  {
    public static void Main(String[] args)
    {
      DateTime dat = DateTime.Now;

      //variables
      String fn = "";
      String ln= "";

      Console.WriteLine("Title: Skillset 7 - Using classes");
      Console.WriteLine("Author: Lucas Costa");
      Console.WriteLine("*  Now: {0:d}, {0:T}    *", dat);       //display current date and time


      Console.WriteLine("\nCreating person object from default constructor (acceppts no argument):");

      Person v1 = new Person(); //created default object
      Console.WriteLine("First name: " + v1.getFname());
      Console.WriteLine("Last Name: " + v1.getLname());


      Console.WriteLine("\nModify default constructor object's data member values: "); //ask for user input, set it to Person objects
      Console.WriteLine("Use setter/getter methods:");

      Console.Write("\nfname: ");
      fn = Console.ReadLine();
      Console.Write("lname: ");
      ln = Console.ReadLine();
      Console.WriteLine("");

      Console.WriteLine("Display object's new data member values:");
      Console.WriteLine("First name (fname): " + fn);
      Console.WriteLine("Last name (lname): " + ln);
      Console.WriteLine("");

      Console.WriteLine("Call parameterized constructor (accept two arguments):");
      Console.Write("First name: ");
      fn = Console.ReadLine();
      Console.Write("Last name: ");
      ln = Console.ReadLine();

      Person v2 = new Person(fn, ln); //Put out 'Person' with user inputted info, w/ get'name'
      Console.WriteLine("\nCreating object from parameterized constructor");
      Console.WriteLine("Full name: " + v2.getFname() + " " + v2.getLname());

    }
  }
}
