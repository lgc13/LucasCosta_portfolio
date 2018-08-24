#include <iostream>
#include <stddef.h>

using namespace std;

int main (void)
{
  char word1[] = "blue";
  char word2[5] = "teal";

  if ( strcmp ( word1, word2 ) < 0 ) cout << "a less b " << endl;
  else cout << "not " << endl;

return 0;
}
