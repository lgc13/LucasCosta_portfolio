/*******************************************************************************************/
/*      Person program. Created by Lucas Costa, July 7, 2016                       */
/*  the point of the program is to                    */
/*                   */
/*******************************************************************************************/

class Person
{
  //instance variable
  private String fname;
  private String lname;
  private int age;

  //default constructor
  public Person()
  {
    System.out.println("\nInside Person default constructor");
    fname = "John";
    lname = "Doe";
    age = 21;
  }

  //parameter constructor
  public Person(String fname, String lname, int age)
  {
    System.out.println("Inside Person constructor with parameters.\n");
    this.fname = fname;
    this.lname = lname;
    this.age = age;
  }

  public String getFname()
  {
    return fname;
  }

  public void setFname(String fn)
  {
    //set instance variable value to parameter value
    fname = fn;
  }

  public String getLname()
  {
    return lname;
  }

  public void setLname(String ln)
  {
    lname = ln;
  }

  public int getAge()
  {
    return age;
  }

  public void setAge(int y)
  {
    age = y;
  }

  public void print()
  {
    System.out.println("\nfname: " + fname + " lname: " + lname + " age: " + age);
  }
}
