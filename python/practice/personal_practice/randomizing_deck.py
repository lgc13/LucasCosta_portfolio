# learning how to randomize a deck, and remove items after being picked
# import modules
import itertools, random
from random import shuffle

# make a deck of cards
deck = list(itertools.product(['Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10'],['Spade','Heart','Diamond','Club']))

print deck[0][0], "of", deck[0][1]
print deck[1][0], "of", deck[1][1]
#shuffle the cards
random.shuffle(deck)

# while deck:
#     # pick a card
#     print("You got:")
#     for i in range(1):
#        print deck[i][0], "of", deck[i][1]
#        deck.pop(i)   # remove that card from deck
#
#     print "done:"  # checking if it was removed
#
#
# for i in deck:
#     print i, deck.index(i)



# rank = [1, 2, 3, 4, 5, 6]
# suit = ['d', 'h', 's', 'c']
# deck = [[rank, suit]]
# shuffle(deck)
#
# # for i, j in rank:
# #     deck.append(rank, suit)
#     # print i
#
# print rank
# print suit
# print deck
# shuffle(rank)
# while rank:
#     # deck.pop()
#     shuffle(rank)
#     shuffle(suit)
#     rank2 = rank
#     suit2 = suit
#     while rank2:
#         print "Card", rank2.pop(), "of suit:", suit2.pop()

# Python program to shuffle a deck of card using the module random and draw 5 cards







   # deck.remove(deck[i][0])
   # deck2 = deck

# while deck:
#     deck.pop()
#     # shuffle(deck)
#     print("You got:")
#     for i in range(1):
#        print deck[i][0], "of", deck[i][1]
#     # deck2 = deck
    # while deck2:
    #     # draw one cards
    #     print("You got:")
    #     for i in range(1):
    #        print deck[i][0], "of", deck[i][1]




# deck2 = ([1, 2],[3, 4])

# print deck[19][0]
# print deck2
