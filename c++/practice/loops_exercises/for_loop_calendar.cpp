#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main(void)
{
  cout << " SUN MON TUE WED THU FRI SAT" << endl;
  for (int d = 1; d < 31; d++)
    {
      cout << setw(4) << d;
    }

return 0;
}
