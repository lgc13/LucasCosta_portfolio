#include <iostream>
#include <fstream>
#include <string>

using namespace std;

void PrintArray(char Array[][72]);
void CountBlobs(char Array[][72], int row, int col);

int main(void)
{
  //STEP 1
  char Array[22][72];

  for (int i = 0; i < 22; i++) //initializing array with spaces with 2 for loops
  {
    for (int k = 0; k < 72; k++)
    {
      Array[i][k] = ' ';   //adding a space to each slot in the array
    }
  }

  //STEP 2 :   Read file into array
  ifstream input;
  input.open("blob.txt");

  string line;
  for (int i = 0; i < 20; i++)   //gets the entire line (70 chars long) and
  {                               //stick it into line
    getline(input, line);
    for (int j = 0; j < 70; j++)  //goes through 'line' and read each character,
    {
      Array[i + 1][j + 1] = line[j];  //adding it to j
    }
  }
  //ledger
  cout << "         1         2         3         4         5         6         7" << endl;
  cout << "1234567890123456789012345678901234567890123456789012345678901234567890" << endl;

  PrintArray(Array); //make sure the array looks good

  int numBlobs = 0;               //counting blobs, and removing Xs
  for (int i = 1; i <= 20; i++)
  {
    for(int j = 1; j <= 70; j++)
    {
      if(Array[i][j] == 'X')
      {
        numBlobs++;
        CountBlobs(Array, i, j);
        cout << "Blob found at row: " << i << " and col: " << j << endl;
      }
    }
  }

  cout << "There are " << numBlobs << " BLOBS in the file" << endl;

  input.close();
return 0;
}

/****************************************************/
/* Function: PrintArray                             */
/* This function takes in the Array and outputs it  */
/*   with the file 'blob.text' put in it            */
/* creted by Lucas C                                */
/****************************************************/
void PrintArray(char Array[][72]) //outputs the input file. 10 XC points
{
  for (int i = 1; i <= 20; i++)
  {
    for (int k = 1; k <= 70; k++)
    {
      cout << Array[i][k];
    }
    cout << endl;
  }
}

/************************************************************/
/* Function CountBlobs                                      */
/* this function takes in each X and makes it a space ' '   */
/*  then it checks if there is another X around the first X */
/*  with all the if statments, then re runs the same        */
/*************************************************************/
void CountBlobs(char Array[][72], int row, int col)
{
  Array[row][col] = ' ';  //make the X a space

  if(Array[row - 1][col] == 'X')
  {
    CountBlobs(Array, row - 1, col);
  }
  if(Array[row - 1][col - 1] == 'X')
  {
    CountBlobs(Array, row - 1, col - 1);
  }
  if(Array[row][col - 1] == 'X')
  {
    CountBlobs(Array, row, col - 1);
  }
  if(Array[row][col - 1] == 'X')
  {
    CountBlobs(Array, row, col - 1);
  }
  if(Array[row + 1][col - 1] == 'X')
  {
    CountBlobs(Array, row + 1, col - 1);
  }
  if(Array[row + 1][col] == 'X')
  {
    CountBlobs(Array, row + 1, col);
  }
  if(Array[row + 1][col + 1] == 'X')
  {
    CountBlobs(Array, row + 1, col + 1);
  }
  if(Array[row][col + 1] == 'X')
  {
    CountBlobs(Array, row, col + 1);
  }
  if(Array[row - 1][col + 1] == 'X')
  {
    CountBlobs(Array, row - 1, col + 1);
  }
}
