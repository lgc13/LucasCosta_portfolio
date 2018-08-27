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

Player draws a card
We check what is the card type
We complete that card type action
Send card to dead-pile
Move to next player
