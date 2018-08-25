//this is used for room_calculator implementation. Thi is the class

using System;

namespace roomClass  //declare the scope 'roomClass'
{
  public class Room
  {
    //instance variable

    //private string fname;  //used last assignment
    //private string lname;  //used last assignment
    private string roomType;  //room type
    private double roomLength; //room length
    private double roomWidth;
    private double roomHeight;

    public Room()
    {                      //default constructor
                          //these aren't changed, accept no arguments
      roomType = "Default";
      roomLength = 10.0;
      roomWidth = 10.0;
      roomHeight = 10.0;

      Console.WriteLine("1- Creating " + this.roomType + " room object from default constructor (accepts no arguments):");
    }

    public Room(string t, double l, double w, double h)
    {         //parameterized constructor that accepts 4 arguments
      roomType = t;
      roomLength = l;
      roomWidth = w;
      roomHeight = h;

      Console.WriteLine("\n4- Call parameterized constructor (accepts four arguments (using object2)):");
    }

    /************** mutator/'setter' methods ***************/
    public void SetType(string t = "default")    //being passed in from room_calculator.cs
    {                           //setter method
      this.roomType = t;
    }

    public void SetLength(double l = 0.0)
    { //setter method
      this.roomLength = l;
    }

    public void SetWidth(double w = 0.0)
    { //setter method
      this.roomWidth = w;
    }

    public void SetHeight(double h = 0.0)
    { //setter method
      this.roomHeight = h;
    }


    /************ accessor/'getter' methods ***********/
    public string GetRoomType()
    {
      return roomType;
    }

    public double GetRoomLength()
    {
      return roomLength;
    }

    public double GetRoomWidth()
    {
      return roomWidth;
    }

    public double GetRoomHeight()
    {
      return roomHeight;
    }

    public double GetRoomArea()
    {
      return roomLength * roomWidth;
    }

    public double GetRoomVolume()
    {
      return roomLength * roomWidth * roomHeight;
    }
  }
}
