/* Assignment 5 for COP 3014 class created by Lucas Costa */
#include <iostream>

using namespace std;

//Prototypes
void RunArray(int *MyArray, int ArraySize);
int AskForNumbers(int *MyArray, int ArraySize);
void PrintArray(int *MyArray, int count);
void Average(double total, int count);
void HammingSort(int *MyArray, int count);

int main(void)
{
  //variables
  int count = 0;
  int MyArray[100];
  int ArraySize = 100;
  int total = 0;

  //RunArray(MyArray,ArraySize);  //set array slots from 1 to 100 (not needed for actual exercise)

  //start:
  cout << "Enter a series of positive numbers." << endl;
  cout << "Entering a negative number will stop input" << endl;

  count = AskForNumbers(MyArray, ArraySize);     //run function to get input, set it = to 'count'

  cout << "Total numbers input: " << count << endl;

  HammingSort(MyArray, count);    //sort numbers input

  cout << "Sorted List: " << endl;
  PrintArray(MyArray, count);         //print out array with numbers input

  for (int i = 0; i < count; i++)   // find total of all numbers put in
  {
    total += MyArray[i];
  }
  Average(total, count);          //find average and display it

  return 0;
}

int AskForNumbers(int *MyArray, int ArraySize) //ask the user to input numbers, return count of how many numbers input
{
  int a = 1;
  int count = 0;
  double total = 0;

  while (a > 0)       //while 'a' is positive, ask for input
  {
    cin >> a;         //user input
    for (int i = 0; i < ArraySize; i++)
    {
      MyArray[count] = a;
      total = a;
    }

    if(a > 0)    //keep count of how many numbers were input
    {
      count++;
    }
  }
  return count;
}

/*void RunArray(int *MyArray, int ArraySize)   //for practice only
{
  for (int i = 0; i < ArraySize; i++)
  {
    MyArray[i] = i + 1;
  }
} */

void HammingSort(int *MyArray, int count)    //sort all numbers in ascending order
{
  for (int i = 0; i < count - 1; i++)
  {
    if (MyArray[i] > MyArray[i + 1])
    {
      int temp = MyArray[i];
      MyArray[i] = MyArray[i + 1];
      MyArray[i + 1] = temp;

      for (int k = i; k >= 1; k--)
      {
        if (MyArray[k - 1] > MyArray[k])
        {
          int temp2 = MyArray[k - 1];
          MyArray[k - 1] = MyArray[k];
          MyArray[k] = temp2;
        }
      }
    }
  }
}

void PrintArray(int *MyArray, int count)   //print out sorted array
{
  for (int i = 0; i < count; i++)
  {
    cout << MyArray[i] << endl;
  }
}

void Average(double total, int count)  //average
{
  cout << "The average is: " << total/count << endl;

}
