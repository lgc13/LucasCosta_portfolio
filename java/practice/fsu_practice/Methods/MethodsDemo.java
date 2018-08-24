/*
//generic syntax:
modifier returnType methodName (formal parameters)
{
  //method body
}

modifier (optional): defines access type
returnType: value-returning or void
methodName: method name
parameter List (optional): type, order, and number of parameter
method body: statements
method signiature:
method header: modifer + returnType + methodSigniature

//example
public static int methodName (float x, double y)
{
  //statements...
}
*/
public class MethodsDemo
{
  // value returning method returns summation of two integers
  public static int addNums (int n1, int n2)  //you have to return an 'int' ALSO, has two parameters (n1 and n2)
  {
    return n1 + n2;
  }

  // value returning method returns summation of two doubles ! METHODS BLOW!
  public static double addNums (double n1, double n2)
  {
    return n1 + n2;
  }

  public static void print (char myChar)
  {
    System.out.println("Course grade: " + myChar);
  }


  public static void main(String[] args)
  {
    int a = addNums (1,2); //calls value returning method, pass int values
    System.out.println("Sum of integer numbers = " + a);

    double b = addNums (2.0, 3.0); // call value returning method, pass int values
    System.out.println("Sum of integer numbers = " + b);

    print('A'); //call void method, pass char value
  }
}
