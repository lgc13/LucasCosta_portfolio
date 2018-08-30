# Yahtzee Game project

<!-- Project BIO -->
This is a console application that allows users to play Yahtzee, a fun game where they can roll dice and add up points. The game starts off asking for the number of players and allows each to input their own name. Afterward, each player can take turns rolling the dice up to 3 times, being able to edit them at any point. At the end of the turn, that player's points are added up to their total. The person with the highest points, wins!

This project was done during a 2-day Hackathon at FSU, in collaboration with 2 other teammates, [Sasha Larson](https://github.com/sjlarson92) and [Devesh Waingakar](https://github.com/devesh15951).

This application displays some of my skills with:

- Object-Oriented Programming
- User input validation
- Lists and Dictionaries
- Using external modules
- Mathematical Algorithms

<!-- Screenshots -->
<img src="img/yahtzee_screen_shot.png" width= 80% length= 80%>

<!-- Code explanation -->
To randomize the dice rolls, we import the random module which has a randint method. Here, we iterate through each player, randomizing the values of the dice, then appending them onto a list which we can display to the console.

<!-- Code snippet -->
You can see that in this code snippet:

```python

for i in names:
      raw_input("\n%s: it's your turn. Press ENTER to roll the dice" % i)
      for i in range(diceMaxLength):
          dice.append(random.randint(1,6))
      print dice

```

<!-- Adding a blank line -->
<br>

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/python/" class="previous">&laquo; Back to Python projects</a>
