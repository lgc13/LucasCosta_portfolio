/*******************************************************************************************/
/*      PersonInheritanceEmployee program. Created by Lucas Costa, July 13, 2016                       */
/*  the point of the program is to                    */
/*                   */
/*******************************************************************************************/

class Employee extends Person
{
  //instance variable
  private int ssn;
  private char gender;

  public Employee()  //default constructor
  {
    super();
    System.out.println("\nInside Employee default constructor");
    ssn = 12389808;
    gender = 'X';
  }

  //parameter constructor
  public Employee(String f, String l, int y, int s, char g)
  {
    super(f,l,y);
    System.out.println("Inside employee constructor with parameters.\n");
    ssn = s;
    gender = g;
  }

  public int getSsn()
  {
    return ssn;
  }

  public void setSsn(int s)
  {
    //set instance variable value to parameter value
    ssn = s;
  }

  public char getGender()
  {
    return gender;
  }

  public void setGender(char g)
  {
    gender = g;
  }

  public void print()
  {
    super.print();
    System.out.println("\nSSN: " + ssn + " Gender: " + gender);
  }
}
