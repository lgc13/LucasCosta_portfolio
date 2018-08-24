#include <iostream>
#include <fstream>

using namespace std;

int main(void)
{
  ofstream outputfile;
  outputfile.open("out.txt");
  outputfile << "Hello World" << endl;
  outputfile.close();


return 0;
}
