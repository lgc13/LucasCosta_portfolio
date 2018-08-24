using System;

namespace personClass
{
  public class Person
  {
    //instance variable
    private String fname;
    private String lname;

    //default constructor
    public Person()
    {
      Console.WriteLine("\nInside Person default constructor");
      fname = "John";
      lname = "Doe";
    }

    public Person(string fn, string ln)
    {
      fname = fn;
      lname = ln;
    }

    public String getFname()
    {
      return fname;
    }
    public String getLname()
    {
      return lname;
    }

    public void setFname(String fn)
    {
      //set instance variable value to parameter value
      fname = fn;
    }

    public void setLname(String ln)
    {
      lname = ln;
    }

  }
}
