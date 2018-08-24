#include <iostream>
using namespace std;

int main(void)
{ const char player[2] = {'O','X'};
  char grid[3][3] = {' ',' ',' ', ' ', ' ',' ',' ',' ',' '};
  char position;
  const int ROW[10] = {0,0,0,0,1,1,1,2,2,2};
  const int COL[10] = {0,0,1,2,0,1,2,0,1,2};
  int iposition;
    for (int move = 1; move <=9; move++)
    {
      cin >> position;
      //input the move and checked it.
      iposition = (int)position - (int)'0';
      grid[ROW[iposition]][COL[iposition]] = player[move % 2];
    }

  return 0;
}
