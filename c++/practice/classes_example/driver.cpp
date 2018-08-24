#include <iostream>
#include <string>
#include <iomanip>
#include "measurements.h"

using namespace std;

int main(void)
{

  Measurements mybody(59, 205);
  mybody.PrintSummary();
  //mybody.Grow();
  

  cout << "end of program" << endl;

return 0;
}
