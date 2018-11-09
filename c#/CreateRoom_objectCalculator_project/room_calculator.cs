/*******************************************************************************************/
/*      room_calculator implementation program. Created by Lucas Costa on Oct 23, 2016                       */
/*  the point of the program is to use the class 'room.cs'                   */
/*  in order to populate different constructors                      */
/*******************************************************************************************/

using System; //imports all libraries
namespace roomClass
{
  public class room_Calculator //declared class
  {
    public static void Main(String[] args)
    {
      DateTime dat = DateTime.Now;

      Console.WriteLine("***********************************************************************************");
      Console.WriteLine("Information and Requirements:");
      Console.WriteLine("Title: Project 1 - Room Calculator");
      Console.WriteLine("Author: Lucas Costa");
      Console.WriteLine("*  Now: {0:d}, {0:T}    *", dat);       //display current date and time
      Console.WriteLine("  1) Create Room class");
      Console.WriteLine("  2) Create following fields (aka properties or data members)");
      Console.WriteLine("    a. private string type //room type");
      Console.WriteLine("    b. private double length // room length");
      Console.WriteLine("    c. private double width // room width");
      Console.WriteLine("    d. private double height //room height");
      Console.WriteLine("  3) Create two constructors");
      Console.WriteLine("    a. Default constructor");
      Console.WriteLine("    b. parameterized constructor that accepts four arguments (four fields above)");
      Console.WriteLine("  4) Create the following mutator (aka setter) methods:");
      Console.WriteLine("    a. SetType");
      Console.WriteLine("    b. SetLength");
      Console.WriteLine("    c. SetWidth");
      Console.WriteLine("    d. SetHeight");
      Console.WriteLine("  5) Create the followign accessor (aka getter) methods:");
      Console.WriteLine("    a. GetType");
      Console.WriteLine("    b. GetLength");
      Console.WriteLine("    c. GetWidth");
      Console.WriteLine("    d. GetHeight");
      Console.WriteLine("    e. GetArea");
      Console.WriteLine("    f. GetVolume");
      Console.WriteLine("  6) Must include the following functionalilty:");
      Console.WriteLine("    a. Display room size calculations in feet (as per below)");
      Console.WriteLine("    b. Must include data validation");
      Console.WriteLine("    c. Round to two decimal places");
      Console.WriteLine("  7) Allow user to press any key to return back to command line.");
      Console.WriteLine("************************************************************************");

      string requirements =
      @"
      -----

      this is another way of writing many strings in c#
      use say
      'string variable_name =
      @''
      then write something inside, and end with this:
      '';
      Console.WriteLine(variable_name);

      ----";
      Console.WriteLine(requirements);

      //program starts using 'room' class, here
      Room roomObject = new Room(); //declared and instanciates the object 'roomObject'
      Console.WriteLine("Room Type: " + roomObject.GetRoomType());
      Console.WriteLine("Room Length: " + roomObject.GetRoomLength());
      Console.WriteLine("Room Width: " + roomObject.GetRoomWidth());
      Console.WriteLine("Room Height: " + roomObject.GetRoomHeight());
      Console.WriteLine("Room Area: " + roomObject.GetRoomArea() + " sq ft");
      Console.WriteLine("Room Volume: " + roomObject.GetRoomVolume().ToString("F2") + " cu ft"); //output double with 2 decimals (ToString("F2"))
      Console.WriteLine("Room Volume: " + (roomObject.GetRoomVolume()/27).ToString("F2") + " cu yd"); //output double with 2 decimals (ToString("F2"))

      Console.WriteLine("\n2- Modify the default room constructor's data member values:" );
      Console.WriteLine("Use setter/getter methods");
      //Initialize some variables to output
      double rLength = 0.0;
      double rWidth = 0.0;
      double rHeight = 0.0;

      Console.Write("Room type: ");
      roomObject.SetType(Console.ReadLine());

      Console.Write("Room length: ");
      while(!double.TryParse(Console.ReadLine(), out rLength))
      {
        Console.Write("Please input a numberic length: ");
      }

      Console.Write("Room width: ");
      while(!double.TryParse(Console.ReadLine(), out rWidth))
      {
        Console.Write("Please input a numberic width: ");
      }

      Console.Write("Room height: ");
      while(!double.TryParse(Console.ReadLine(), out rHeight))
      {
        Console.Write("Please input a numberic height: ");
      }

      //setting the constructor variables equal to the new inputted
      roomObject.SetLength(rLength);
      roomObject.SetWidth(rWidth);
      roomObject.SetHeight(rHeight);

      Console.WriteLine("\n3- Display " + roomObject.GetRoomType() + " room object's NEW data member values");
      Console.WriteLine("Room Type: " + roomObject.GetRoomType());
      Console.WriteLine("Room Length: " + roomObject.GetRoomLength());
      Console.WriteLine("Room Width: " + roomObject.GetRoomWidth());
      Console.WriteLine("Room Height: " + roomObject.GetRoomHeight());
      Console.WriteLine("Room Area: " + roomObject.GetRoomArea() + " sq ft");
      Console.WriteLine("Room Volume: " + roomObject.GetRoomVolume().ToString("F2") + " cu ft"); //output double with 2 decimals (ToString("F2"))
      Console.WriteLine("Room Volume: " + (roomObject.GetRoomVolume()/27).ToString("F2") + " cu yd"); //output double with 2 decimals (ToString("F2"))

      Room roomObject2 = new Room("string", 10.0, 10.0, 10.0, "thomas");  //creating new room for 'roomObject2'
      Console.Write("Room type: ");
      roomObject2.SetType(Console.ReadLine());

      Console.Write("Room length: ");
      while(!double.TryParse(Console.ReadLine(), out rLength))
      {
        Console.Write("Please input a numberic length: ");
      }

      Console.Write("Room width: ");
      while(!double.TryParse(Console.ReadLine(), out rWidth))
      {
        Console.Write("Please input a numberic width: ");
      }

      Console.Write("Room height: ");
      while(!double.TryParse(Console.ReadLine(), out rHeight))
      {
        Console.Write("Please input a numberic height: ");
      }

      //setting the new constructor variables equal to the new inputted
      roomObject2.SetLength(rLength);
      roomObject2.SetWidth(rWidth);
      roomObject2.SetHeight(rHeight);

      Console.WriteLine("\n5- Creating " + roomObject2.GetRoomType() + " object from parameterized constructor:");
      Console.WriteLine("Room Type: " + roomObject2.GetRoomType());
      Console.WriteLine("Room Length: " + roomObject2.GetRoomLength());
      Console.WriteLine("Room Width: " + roomObject2.GetRoomWidth());
      Console.WriteLine("Room Height: " + roomObject2.GetRoomHeight());
      Console.WriteLine("Room Area: " + roomObject2.GetRoomArea() + " sq ft");
      Console.WriteLine("Room Volume: " + roomObject2.GetRoomVolume().ToString("F2") + " cu ft"); //output double with 2 decimals (ToString("F2"))
      Console.WriteLine("Room Volume: " + (roomObject2.GetRoomVolume()/27).ToString("F2") + " cu yd"); //output double with 2 decimals (ToString("F2"))

      Console.WriteLine("\nPress any key to exit");
      Console.ReadKey();
    }
  }


}
