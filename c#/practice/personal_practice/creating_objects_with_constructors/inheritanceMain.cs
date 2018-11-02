using System; //imports all libraries

namespace a4inheritance
{
  public class inheritanceMain //declared class
  {
    public static void Main(String[] args)
    {
      DateTime dat = DateTime.Now;

      string requirements =
      @"
      ************************************************************
      Information and Requirements:
      Title: Assignment 4 - Class Inheritance
      Author: Lucas Costa

        1) Create Person class (stored in different file)
          A) Create three protected data members
            a. fname
            2. lname
            3. age
          B) Create three setter/mutator methods:
            1. SetFname
            2. SetLname
            3. SetAge
          c) Create four getter/accessor methods:
            1. GetFname
            2. GetLname
            3. GetAge
            4. GetObjectInfo (virtual method (returns string): allows derived class to override base class method)

        NOTE: for this exercise, do not use shorthand/shortcut get/set methods
          d) Create two constructors
            1. Default constructor
            2. parameterized constructor that accepts four arguments (four fields above)
          e) Instantiate two person objects:
            1. one from default constructor (displaus deafault values)
            2. one from parameterzed constructor passing two arguments

        2) Creat Stundet class (in a different file)
          a) Craete three private data members:
            1. college
            2. major
            3. gpa
          b) Create three getter/accessor methods:
            1. GetName
            2. GetFullName
            3. GetObjectInfo (demonstrates polymorphism: one interface, multple purposes or roles)

        NOTE: for this exercise, don't use shorthand or shortcuts
          c) create two constructors:
            1. Default constructor
            2. parameterized constructor that accepts four arguments (four fields above)
          d) Instantiate two student objects:
            1. one from default constructor (displaus deafault values)
            2. one from parameterzed constructor passing two arguments

        3) Allow user to press any key to return back to command line.
        **************************************************************
       ";
      Console.WriteLine(requirements);

      Console.WriteLine("  Now: {0:d}, {0:T}    ", dat);       //display current date and time
      //program starts using 'room' class, here
      Person personObject = new Person(); //declared and instanciates the object 'personObject'
      Console.WriteLine("First Name: " + personObject.GetFname());
      Console.WriteLine("Last Name: " + personObject.GetLname());
      Console.WriteLine("Age: " + personObject.GetAge());

      Console.WriteLine("\n2- Modify the default room constructor's data member values:" );
      Console.WriteLine("Use setter/getter methods");
      //Initialize some variables to output
      double ageNumber = 0.0;

      Console.Write("First name: ");
      personObject.SetFname(Console.ReadLine());

      Console.Write("Last Name: ");
      personObject.SetLname(Console.ReadLine());

      Console.Write("Age: ");
      while(!double.TryParse(Console.ReadLine(), out ageNumber))
      {
        Console.Write("Please input a numberic age: ");
      }

      //setting the constructor variables equal to the new inputted
      personObject.SetAge(ageNumber);

      Console.WriteLine("\n3- Display " + personObject.GetFname() + " room object's NEW data member values");
      Console.WriteLine("First Name: " + personObject.GetFname());
      Console.WriteLine("Last Name: " + personObject.GetLname());
      Console.WriteLine("Age: " + personObject.GetAge());


      Person personObject2 = new Person("string", "another string", 0);  //creating new room for 'personObject2'
      Console.Write("First name: ");
      personObject2.SetFname(Console.ReadLine());

      Console.Write("Last name: ");
      personObject2.SetLname(Console.ReadLine());

      Console.Write("Age: ");
      while(!double.TryParse(Console.ReadLine(), out ageNumber))
      {
        Console.Write("Please input a numberic age: ");
      }

      //setting the new constructor variables equal to the new inputted
      personObject2.SetAge(ageNumber);

      Console.WriteLine("\n5- Creating " + personObject2.GetFname() + " object from parameterized constructor:");
      Console.WriteLine("First name: " + personObject2.GetFname());
      Console.WriteLine("Last Name: " + personObject2.GetLname());
      Console.WriteLine("Age: " + personObject2.GetAge());

      Student studentObject = new Student();
      Console.WriteLine("First name: " + studentObject.GetFname());
      Console.WriteLine("Last Name: " + studentObject.GetLname());
      Console.WriteLine("Age: " + studentObject.GetAge());

      Console.WriteLine("\nDemonstrating polymorphism");
      Console.WriteLine("Calling parameterized base class constructor");
      Console.Write("First name: ");
      string student_fname = Console.ReadLine();

      Console.Write("Last name: ");
      string student_lname = Console.ReadLine();

      double student_age = 0;
      Console.Write("Age: ");
      while(!double.TryParse(Console.ReadLine(), out student_age))
      {
        Console.Write("Please input a numberic age: ");
      }

      Console.Write("College: ");
      string student_college = Console.ReadLine();

      Console.Write("Major: ");
      string student_major = Console.ReadLine();

      double student_gpa = 0;
      Console.Write("GPA: ");
      while(!double.TryParse(Console.ReadLine(), out student_gpa))
      {
        Console.Write("Please input a numberic gpa: ");
      }

      Student studentObject2 = new Student(student_fname, student_lname, student_age, student_college, student_major, student_gpa);  //creating new room for 'personObject2'
      Console.WriteLine("\npersonObject2 - GetObjectInfo (virtual:)");
      Console.WriteLine(personObject2.GetObjectInfo());

      Console.WriteLine("\nstudentObject2 - GetObjectInfo (virtual:)");
      Console.WriteLine(studentObject2.GetObjectInfo());

      Console.WriteLine("\nPress any key to exit");
      Console.ReadKey();
    }
  }


}
