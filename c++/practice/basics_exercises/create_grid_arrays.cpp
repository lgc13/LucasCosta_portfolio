#include <iostream>
using namespace std;
const int GRIDSIZE = 3;

int main (void)
{
  char grid[GRIDSIZE] [GRIDSIZE] = {};
  grid[1][1] = 'Y';

  for (int row = 0; row < GRIDSIZE; row++)
  for (int col = 0; col < GRIDSIZE; col++)
  cout << grid[row][col] << '|';
  cout << endl;


return 0;
}
