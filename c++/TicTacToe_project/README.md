# TicTacToe_project

<!-- Project BIO -->
Tic Tac Toe is a really fun and easy game to play. I created this console app which can be played by 2 people on the same console. I created a few functions that could easily be reused when needed, as I had not learned of object oriented programming yet.

This application displays some of my skills with:

- code reusability (a single board layout was used)
- user input validation  
- game win condition validation
- loops through arrays
- function calls

<!-- Screenshot -->
<img src="img/pic1.png" width= 60% length= 60%>

<!-- Code explanation -->
I used a single function to create the playing board whenever it was necessary. By passing in an array with the current values of each index, I could print out a centered board with "walls" such as ---+---+--- and |. I iterated through the board length with a for loop, using setw to adjust the width location of every input value, even if that were a blank character.

<!-- Code snippet -->
You can see that in this code snippet:

```c++

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

```

<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/c++/" class="previous">&laquo; Back to C++ projects</a>
