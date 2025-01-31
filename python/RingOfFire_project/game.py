# Lucas Costa's Ring of Fire game third edition, created Sep 01, 2018
import itertools, random

CARD_ACTIONS = {
    'Ace': "Waterfall..Everyone Drinks",
    '2': "Fuck you: Tell someone to drink",
    '3': "Fuck me: You drink!",
    '4': "Floor: last person to touch the floor, drinks!",
    '5': "Guys: all men must toast",
    '6': "Chicks: all ladies must toast",
    '7': "Heaven: last peron to point up must drink",
    '8': "Date: pick someone. You must both drink together when the other drinks, until the end of the game",
    '9': "Rhyme: say a word which everyone must rhyme with, going around clockwise. The person who can't, drinks",
    '10': "Question Master: the person holding this card must always drink double. \n\tThe only way to get rid of this card, is by asking someone a question. If they verbally answer the question(without another question) then they take this card. \n\t* If another 10 is drawn, put the old on in the dead-pile",
    'Jack': "Thumb Master: at any point, put your thumb on the table without saying anything. Everyone must do the same once you've done this. \n\tLast person to do it, drinks. You can continually do this until another Jack is pulled",
    'Queen': "Queen Rule: create a rule that must be obeyed for the entirety of the game by all players. \n\tAny other Queen Rules added will stack. \n\tIf any Queen Rule is broken at any time, that person must drink. \n\t* Queen Rule cannot be overruled by anything, including a 'King'",
    'King': "KING: place this card on your forehead. Until it falls, you can tell anyone to do anything"

}

def main():
    all_players_list = getPlayers()
    full_cardDeck = getDeckOfCards()
    gameEngine(all_players_list, full_cardDeck)
    print('Game Over')

def getPlayers(): # ask how many players there are, and get all their names

    while(True):  # while this is True,
        try:    # ask for user input, and try converting it to an int
            num_players = int(raw_input("How many players are playing today? "))
            if num_players == 0:
                print("\nCan't play if no one is there! Try again")
            elif num_players < 0:
                print("\nYou gotta give me a positive number of players! Try again")
            else:
                break
        except ValueError:  # if it can't convert, print this then ask for it again
            print("\nYou gotta give me numbers! Try again")
            # continue

    print("Cool! Let's get everyone's name!\n")
    players_list = []

    for player_num in range(num_players):
        playerName = raw_input("What's player %d's name? " % (player_num + 1))
        players_list.append(playerName)

    print("\nAlright, now that we're all acquainted, we can start!")
    print("_________________________________________________________________")

    return players_list

def getDeckOfCards(): # initialize a deck of cards
    deck = list(itertools.product(['Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King'],['Diamonds','Spades','Hearts','Clubs']))
    #deck = ['1', 'Two', '3', '4']
    return deck

def gameEngine(p_list, cardDeck):
    while cardDeck: # while there are still cards in the deck, play game
        for player in p_list:
            raw_input("%s, press ENTER to randomly draw a card!" % player)
            random_card = random.choice(cardDeck) # randomly getting a card from the cardDeck
            card_number, card_suit = cardDeck.pop(cardDeck.index(random_card)) # removes random_card by its index from tuple, and assigns values to card_number and card_suit

            print("Your card is: %s of %s\n" % (card_number, card_suit))
            # random_card = pickACard(cardDeck, random_num) # picks a random_card
            # print 'random_card is: %s' % (random_card,)
            print(CARD_ACTIONS[card_number])
            print("---------------------------------")

            # cardDeck = removeCard(cardDeck, random_num) # remove this card from deck
            if cardDeck == []:
                break # break while loop when cardDeck is empty

# def pickACard(deck, some_number):
#     # print("random_num is %d" % random_num)
#     print("Your card is: %s of %s\n" % (deck[some_number][0], deck[some_number][1]))
#     # print("AFTER self.deck length is: %d" % len(self.deck))
#     # print('self.deck before: %s' % deck)
#     # deck.pop(random_num)
#     # print("BEFORE self.deck length is: %d" % len(self.deck))
#     # print('self.deck after: %s' % deck)
#
#     return deck[some_number]

# def printDirections(card):
#     print CARD_ACTIONS[card]

# def removeCard(deck, rand_num): # remove card from deck
#     deck.pop(rand_num)
#     print("-------------------")
#     return deck

if __name__ == '__main__':
    main()
