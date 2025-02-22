# ticTacToeGame v2, made by Lucas Costa and Sasha Larson
# started on Feb 26, 2017

# what we need in order to make a tic tac toe game in python
# v2: we will also make it so that we can play against the computer
# finally, we will make this 2D

"""
What we need:

1- Board array
2- Players
  a- accept input
3- Rules
4- Fill in board
  a- remember input
  b- show current input
5- Declare winner

How the computer will think/display things

1- Welcome log
2- Display the board
3- Ask for input for player 1
  a- Display board with player 1 input
  b- check if there's a winner
4- Ask for input for player 2
  a- Display board with player 1 and 2 input
  b- check if there's a winner
5- Display winner/tie message
"""

# making board list
row = ['1','2','3']
col = ['',' ',' ']
board2 = [row, col]
board = [["1", "2", "3"],["4", "5", "6"]]

for i in row:
    for j in col:
        print board2

print board
