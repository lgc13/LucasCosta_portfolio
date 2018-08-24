#include <iostream>
#include <fstream> 
using namespace std;

const int FILENAMESIZE=80;
void ClearCharacter(char * c)
{
  for (int i=0; i<FILENAMESIZE; i++)
    c[i]=' ';
} 

void OpenFile(ifstream & MF)
{
  char filename[FILENAMESIZE];
  cout << "\nPlease Enter  a File Name:  " ;
  cin >>filename;
  MF.open(filename);
  while(!MF.is_open())
    { cout <<"\nYou entered : " << filename ;
      ClearCharacter(filename); 
      cout <<"\nDid not open, re-enter: " ;
      cin >> filename;
      MF.open(filename);
    }
  
}

int CountRecords (ifstream & MF)
{

  int counter=0;
  char inputline[FILENAMESIZE];

  MF.getline(inputline,FILENAMESIZE);
  while(!MF.eof())
    { counter++;
    MF.getline(inputline, FILENAMESIZE);
    }
  return counter; 
}


int main (void)
{
  ifstream MyFile;
  OpenFile(MyFile);
  cout << "\nNumber of records: " << CountRecords(MyFile) << endl; 
  MyFile.close(); 

  return 0;
} 
