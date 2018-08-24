#include <iostream>
#include "class_imported.h"

using namespace std;

Measurements::Measurements (const int h, const int w)
{
  height = h;
  SetWeight(w);
}

int Measurements::GetHeight()
{
  return height;
}

int Measurements::GetWeight()
{
  return weight;
}

void Measurements::SetWeight(const int w)
{
  if (w > 0 && w < 1000)
    weight = w;
  else weight = 130;

}
