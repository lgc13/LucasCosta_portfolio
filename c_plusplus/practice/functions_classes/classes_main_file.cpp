#include <iostream>
#include <string>
#include <iomanip>
#include "class_imported.h"

using namesapce std;

int main(void)
{
  Measurements David (58, 205);
  Measurements Larry (62, 210);

  cout << David.GetHeight() << endl;
  cout << Larry.GetWeight() << endl;

return 0;
}
