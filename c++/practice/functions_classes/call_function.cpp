#include <iostream>
using namespace std;

void Add100ToX(int & x);

int main(void)
{
  int x = 3;
  Add100ToX(x);
  cout << "X is now " << x << endl;

  return 0;
}

void Add100ToX(int & x)
{
  x = 100 + x;
}
