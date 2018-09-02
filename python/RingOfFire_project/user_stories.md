Welcome to my "Ring of Fire" game readme

I'm using the party card game commonly known as "Waterfall" or "Ring of Fire",
and making it playable through a console.

* Summary: The game focuses on a single deck of cards that are all placed down.
Each card depending on its number, grants the player an action.
Each player takes a turn to randomly choose a card, and once the action is
completed, that card is placed on a dead-pile.
This repeats until all cards have been drawn.

* Game Analysis and concepts:
- card deck
  - card actions
  - action stacking
- stages
  - draw stage (random)
  - complete card action
  - dead-pile
- main engine
  - play

1. Ask how many players there are
2. Ask for each player's name
3. Create a CardDeck
 - while there are still cards in the CardDeck

3. Iterate through players list
4. Ask player to draw a card
5. Print card instructions
6. Remove card from CardDeck list
