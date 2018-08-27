# Ring of Fire

<!-- Project BIO -->
This is an game console application that can be played by a group of friends at a single computer. The purpose of this application, is to allow people to play the 'Ring of Fire' game, without having to carry on a deck of cards, or remembering each specific rules or action that must be taken - this game does all the heavy lifting, and tells each player what they should do next. Players take turn taking a virtual card, which is followed by some type action that must be taken. This is a drinking game, so expect to have fun :)

This application displays some of my skills with:

- Object Oriented Programming
- Importing modules
- Use of Lists and Dictionaries
- Method calls
- Mathematical Algorithms

<!-- Screenshots -->
<img src="img/pic1.png" width= 80% length= 80%>

<!-- Code explanation -->
I use itertools in order to more easily distribute my deck of cards without having to repeat myself. This allows me to give each card number (Ace through King) 4 different suits (Diamond, Spades, Hearts and Clubs)

<!-- Code snippet -->
You can see that in this code snippet:

```python

self.deck = list(itertools.product(['Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King'],['Diamond','Spades','Hearts','Club']))

```

<!-- Adding a blank line -->
<br>

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/python/" class="previous">&laquo; Back to Python projects</a>
