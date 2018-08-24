#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main(void)
{
  int len = 0;
  string word;
  cout << "Enter in a word to center: " ;
  cin >> word;
  len = word.length();
  len = ((40 - len) / 2);

  for (int i = 0; i < len; i++) cout << ' ';
  cout << word << endl;
  cout << "xxxxxxxxxxxxxxxxxxxXxxxxxxxxxxxxxxxxxxxx" << endl;




return 0;
}
