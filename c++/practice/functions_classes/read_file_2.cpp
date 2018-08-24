#include <iostream>
#include <fstream>

using namespace std;

const int MAXFILENAME = 80;
void GetAFileNameAndOpenIt(ifstream & f, char * fn);

int main(void)
{
  ifstream inputfile;
  char filename[MAXFILENAME];
  string inputline;

  GetAFileNameAndOpenIt(inputfile, filename);

  while(getline(inputfile, inputline))
    cout << inputline << endl;

  inputfile.close();
  return 0;
}

void GetAFileNameAndOpenIt(ifstream & f, char * fn)
{
  cout << "Enter a valid file name: ";
  cin >> fn;
  f.open(fn);
  while(!f.is_open())
  {
    cout << "invalid file name, please re-enter: ";
    cin >> fn;
    f.open(fn);
  }
}
