#include <iostream>

using namespace std;

const int MAXRECORDS = 10;
void PrintArray(const int na[], const int mr);
void ClearArray(int na[], const int mr);


int main(void)
{
  int narray[MAXRECORDS] = {0,9,8,7,6,5,4,3,2,1};
  PrintArray(narray, MAXRECORDS);
  ClearArray(narray, MAXRECORDS);

  return 0;
}

void PrintArray(const int na[], const int mr)
{
  for (int index = 0; index < mr; index++)
    cout << na[index] << ' ' << endl;

}

void ClearArray(int na[], const int mr)
{
  for (int index = 0; index < mr; index++)
    na[index] = ;

}
