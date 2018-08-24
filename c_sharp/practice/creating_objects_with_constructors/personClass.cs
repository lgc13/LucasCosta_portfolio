using System;

namespace a4inheritance  //declare the scope
{
  public class Person
  {
    //instance variable

    protected string fname;  //used last assignment
    protected string lname;  //used last assignment
    protected double age;

    public Person()
    {                      //default constructor
                          //these aren't changed, accept no arguments
      fname = "First Name";
      lname = "Last Name";
      age = 0;

      Console.WriteLine("1- Creating " + this.fname + this.lname + " objects from default constructor (accepts no arguments):");
    }

    public Person(string fn, string ln, double a)
    {         //parameterized constructor that accepts 3 arguments
      fname = fn;
      lname = ln;
      age = a;

      Console.WriteLine("\n4- Call parameterized constructor (accepts four arguments (using object2)):");
    }

    /************** mutator/'setter' methods ***************/
    public void SetFname(string fn = "First name")    //being passed in from room_calculator.cs
    {                           //setter method
      this.fname = fn;
    }

    public void SetLname(string ln = "Last name")    //being passed in from room_calculator.cs
    {                           //setter method
      this.lname = ln;
    }

    public void SetAge(double a = 0)
    { //setter method
      this.age = a;
    }

    /************ accessor/'getter' methods ***********/
    public string GetFname()
    {
      return fname;
    }

    public string GetLname()
    {
      return lname;
    }

    public double GetAge()
    {
      return age;
    }

    public virtual string GetObjectInfo()
    {
      return fname + "" + lname + " is " + age.ToString();
    }

  }
}
