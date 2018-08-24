/* Assignment 6 for COP 3014 created by Lucas Costa */

#include <iostream>
#include <fstream>
#include <ctype.h>
#include <string>

using namespace std;

/* Prototypes */
int GetNumChars(char * InputFileName, char * OutputFileName, ifstream & myfile, ofstream & output); // & means permanent changes, sending in the actual one
int GetNumWords(char * InputFileName, ifstream & myfile);
void PrintSummary(int CharacterCount, int WordCount, int largestlength, int smallestlength, ofstream & output);


int main (void)
{
  const int MAXFILESIZE = 80;
  char InputFileName[MAXFILESIZE];
  char OutputFileName[MAXFILESIZE];
  int smallestlength = -1;
  int largestlength = 0;
  ifstream myfile;         //this allows me to read the file
  ofstream output;         //this allows me

  cout << "Please enter in an input filename: ";   //inputting in a file name
  cin >> InputFileName; //filename

  myfile.open(InputFileName);
  while(!myfile.is_open())  //make sure file is open, otherwise ask for valid input
  {
    cout << "invalid file name, please re-enter: ";
    cin >> InputFileName;
    myfile.open(InputFileName);
  }
  myfile.close();

  cout << "Please enter in an output filename: ";    //input OUTPUT FILE name
  cin >> OutputFileName; //outputfilename

  output.open(OutputFileName);

  int CharacterCount = GetNumChars(InputFileName, OutputFileName, myfile, output);
  int WordCount = GetNumWords(InputFileName, myfile);

  myfile.open(InputFileName);
  string word;

  while (myfile >> word) //use this to find biggest and smallest lenght items
  {
    if (word.length() < smallestlength || smallestlength == -1)
    {
      smallestlength = (int)word.length();
    }
    if (word.length() > largestlength)
    {
      largestlength = (int)word.length();
    }
  }
  myfile.close();

  PrintSummary(CharacterCount, WordCount, largestlength, smallestlength, output);

  output.close();
return 0;
}

/*******************************************************************/
/* GetNumChars                                                     */
/* Use this to find how many character there are in the input file */
/*******************************************************************/
int GetNumChars(char * InputFileName, char * OutputFileName, ifstream & myfile, ofstream & output)
{
  char MyChar;
  int count = 0;

  myfile.open(InputFileName); //opens the file

  while (myfile.get(MyChar))
  {
    output << (char)toupper(MyChar);   //output as capitals
    if (MyChar != ' ')
    count ++;
  }

  output << endl;
  myfile.close();

  return count;
}

/********************************************************************/
/* GetNumWords                                                     */
/* Use this to find how many words there are in the input file */
/********************************************************************/
int GetNumWords(char * InputFileName, ifstream & myfile)
{
  myfile.open(InputFileName);
  int count = 0;
  string word;

  while (myfile >> word) //count how many words there are
  {
      count++;
  }
  myfile.close();

return count;
}


/********************************************************************/
/* PrintSummary                                                     */
/* Print out all of the counts, lenghts and output                  */
/********************************************************************/
void PrintSummary(int CharacterCount, int WordCount, int largestlength, int smallestlength, ofstream & output)
{
  output << "Word counter summary: " << endl << endl;
  output << "Total number of characters: " << CharacterCount << endl;
  output << "Total number of words: " << WordCount << endl;
  output << "Largest word size: " << largestlength << endl;
  output << "Smallest word size: " << smallestlength << endl;

}
