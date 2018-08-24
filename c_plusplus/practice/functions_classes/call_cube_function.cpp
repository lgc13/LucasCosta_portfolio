#include <iostream>
using namespace std;

double CubeIt(const double );

int main(void)
{
  cout << "The cube of 3.0 is : " << CubeIt(3.0) << endl; 
return 0;
}

double CubeIt(const double anyname)
{

return anyname*anyname*anyname;
}
