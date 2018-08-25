//Created by Lucas Costa for COP 3014 class

#include <iostream>
#include <iomanip>
#include <string>
#include <cstdlib>
using namespace std;

//prototypes
void WelcomeMessage();
void PrintBoard(char Board[9]);
int PlayMe(int PlayerNumber, char PlayerLetter);
int CheckMe(char Board[9]);

int main(void)
{ char PlayerLetter;
  char Board[9] = {' ',' ',' ',' ',' ',' ',' ',' ',' '};
  char player1 = 'X';
  int PlayerNumber1 = 1;
  char player2 = 'O';
  int PlayerNumber2 = 2;
  int position = 0;
  WelcomeMessage();

  while(!CheckMe(Board))
  {
    position = PlayMe(PlayerNumber1,player1);    //run function PlayMe with 'X', and set that = position
    while(Board[position-1] != ' ')
    {
      cout << "Please enter a position that hasn't been played" << endl;
      position = PlayMe(PlayerNumber1, player1);
    }
    Board[position - 1] = player1;               //put in position, and print out 'X' in that array position on Board
    PrintBoard(Board);                           //print out latest Board.

    if (CheckMe(Board))
    {continue;}
    position = PlayMe(PlayerNumber2,player2);   //run function PlayMe with 'O', and set that = position
    while(Board[position-1] != ' ')
    {
      cout << "Please enter a position that hasn't been played" << endl;
      position = PlayMe(PlayerNumber2, player2);
    }
    Board[position - 1] = player2;              //put in position, and print out 'O' in that array position on Board
    PrintBoard(Board);                          //print out latest Board.
  }
  cout << "Player " << CheckMe(Board) << " won" << endl;
  return 0;
}

void WelcomeMessage()
{ //show the welcome message, then call PrintBoard function, giving it char 1-9
  cout << "Welcome to Lucas's Tic Tac Toe Game. " << endl;
  cout << "Below is the playing grid and associative positions you are allowed to move to: " << endl;
  cout << "Positions: \n" << endl;
  char Board[9] = {'1','2','3','4','5','6','7','8','9'};
  PrintBoard(Board);
}

void PrintBoard(char Board[9])
{
  for (int i = 0; i < 9; i++){
      //center numbers and display them from Board array.
      int len = 0;
      string word;
      len = word.length();
      len = ((4 - len) / 2) + len; 
      cout << setw(len) << Board[i]; // print value from given Board Array

      // Go to next line and add --+---+---
      if ((i+1)%3 == 0){
        cout << endl;
        if ((i+1) != 9){
          cout << "---+---+---" << endl;
        }
        else {
          cout << endl;
        }
      }
      //Add a |
      else if ((i+1)%3 != 0){
        cout << " |";
      }
  }
}

int PlayMe(int PlayerNumber, char PlayerLetter)
{
  char x;
  bool askfornumber = true;
  int position = 0;
  //ask player 1 for input (while this is true.)
  while(askfornumber)
  {
  cout << "Player #" << PlayerNumber << ", enter the position (1-9) to place the " << PlayerLetter << " :" << endl;
  cout << "Insert position: ";
  cin >> x;

    //restriction to a number between 1 - 9
    if (x < '1' || x > '9')
    {
      cout << "The input number is invalid. Please enter in a a number between 1 - 9 : " << endl;
    }
    else              //accept number if its b/w 1-9, then it in the position
    {
      askfornumber = false;
      position = x - '0';
    }
  }
  return position;
}

int CheckMe(char Board[9])
{

  if (Board[0] == Board[1] && Board[0] == Board[2] && Board[0] == 'X')
  {
    return 1;
  }
    else if(Board[0] == Board[1] && Board[0] == Board[2] && Board[0] == 'O')
    {
      return 2;
    }

  else if (Board[0] == Board[4] && Board[0] == Board[8] && Board[0] == 'X')
  {
    return 1;
  }
    else if (Board[0] == Board[4] && Board[0] == Board[8] && Board[0] == 'O')
    {
      return 2;
    }

  else if (Board[0] == Board[3] && Board[0] == Board[6] && Board[0] == 'X')
  {
    return 1;
  }
    else if (Board[0] == Board[3] && Board[0] == Board[6] && Board[0] == 'O')
    {
      return 2;
    }

  else if (Board[1] == Board[4] && Board[1] == Board[7] && Board[1] == 'X')
  {
    return 1;
  }
    else if (Board[1] == Board[4] && Board[1] == Board[7] && Board[1] == 'O')
    {
      return 2;
    }

  else if (Board[2] == Board[5] && Board[2] == Board[8] && Board[2] == 'X')
  {
    return 1;
  }
    else if (Board[2] == Board[5] && Board[2] == Board[8] && Board[2] == 'O')
    {
      return 2;
    }

  else if (Board[2] == Board[5] && Board[2] == Board[6] && Board[2] == 'X')
  {
    return 1;
  }
    else if (Board[2] == Board[5] && Board[2] == Board[6] && Board[2] == 'O')
    {
      return 2;
    }

  else if (Board[3] == Board[4] && Board[3] == Board[5] && Board[3] == 'X')
  {
    return 1;
  }
    else if (Board[3] == Board[4] && Board[3] == Board[5] && Board[3] == 'O')
    {
      return 2;
    }

  else if (Board[6] == Board[7] && Board[6] == Board[8] && Board[6] == 'X')
  {
    return 1;
  }
    else if (Board[6] == Board[7] && Board[6] == Board[8] && Board[6] == 'O')
    {
      return 2;
    }

  return 0;
}
