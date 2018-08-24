using System;

namespace a4inheritance  //declare the scope 'personClass'
{
  public class Student: Person
  {
    //instance variable

    private string college;  //used last assignment
    private string major;  //used last assignment
    private double gpa;

    public Student()
    {                      //default constructor
                          //these aren't changed, accept no arguments
      college = "CCI";
      major = "IT";
      gpa = 4.0;

      Console.WriteLine("*- Creating derived student objects from default constructor (accepts no arguments):");
    }

    public Student(string fn, string ln, double a, string c, string m, double g) : base(fn, ln, a)
    {         //parameterized constructor that accepts 3 arguments
      college = c;
      major = m;
      gpa = g;

      Console.WriteLine("\n**- Call derived student parameterized constructor (accepts four arguments (using object2)):");
    }

    /************ accessor/'getter' methods ***********/
    public string GetName()
    {
      return fname + " " + lname;
    }

    public string GetFullName()
    {
      return GetFname() + " " + GetLname();
    }

   public override string GetObjectInfo()
    {
      return base.GetObjectInfo() + " in the college of " + this.college + ", majoring in " + this.major + ", with a GPA of " + this.gpa;
    }
  }
}
