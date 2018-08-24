#include <iostream>
#include "measurements.h"

using namespace std;

Measurements::Measurements(const int h, const int w)
{
  if (h > 0)
    height = h;
    else height = 1;
  if (w > 0)
    weight = w;
    else weight = 1;

}

void Measurements::PrintSummary()
{
  cout << "The height is: " << height << endl;
  cout << "The weight is: " << weight << endl;
}
