# Lucas Costa's Ring of Fire game second edition, created Feb 28, 2017
import itertools, random
from random import shuffle

def main():   # should use this to pass in CardDeck, Bottle, any anything else in through Engine
    x = DeckOfCards(0)
    card_list = x.returnDeckOfCards()
    a = Engine(card_list)
    a.play()

class DeckOfCards(object):

    def __init__(self, player_card):
        self.player_card = player_card
        # is there a way to put the cards and suits together, in an easier way?
        # make a deck of cards
        self.deck = list(itertools.product(['Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King'],['Diamond','Spades','Hearts','Club']))

    def returnDeckOfCards(self):

        return self.deck

    def print_card(self):
        print "\nThe card you picked was: ", self.deck[self.player_card][0], "of", self.deck[self.player_card][1]  # print card here

    def card_rules(self):
        if self.player_card in range(0, 4):
            print "Waterfall..Everyone Drinks"
        elif self.player_card in range(4, 8):
            print "Fuck you: Tell someone to drink"
        elif self.player_card in range(8, 12):
            print "Fuck me: You drink!"
        elif self.player_card in range(12, 16):
            print "Floor: last person to touch the floor, drinks!"
        elif self.player_card in range(16, 20):
            print "Guys: all men must toast"
        elif self.player_card in range(20, 24):
            print "Chicks: all ladies must toast"
        elif self.player_card in range(24, 28):
            print "Heaven: last peron to point up must drink"
        elif self.player_card in range(28, 32):
            print "Date: pick someone. You must both drink together when the other drinks, until the end of the game"
        elif self.player_card in range(32, 36):
            print "Never Have I Ever: take turns clockwise. Whenever someone HAS done something said outloud, that person drinks."
            print "\tWhen someone has drank 3 times, this game stops"
        elif self.player_card in range(36, 40):
            print "Question Master: the person holding this card must always drink double."
            print "\tThe only way to get rid of this card, is by asking someone a question. If they verbally answer the question(without another question) then they take this card"
            print "\t* If another 10 is drawn, put the old on in the dead-pile"
        elif self.player_card in range(40, 44):
            print "Thumb Master: keep this card until you want to use its power"
            print "\tWhenever you desire, place your thumb on the table, and keep playing the game as usual"
            print "\tThe last person to put the thinger on the table, must drink"
        elif self.player_card in range(44, 48):
            print "Queen Rule: create a rule that must be obeyed for the entirety of the game by all players"
            print "\tAny other Queen Rules added will stack"
            print "\tIf any Queen Rule is broken at any time, that person must drink"
            print "\t* Queen Rule cannot be overruled by anything, including a 'King'"
        elif self.player_card in range(48, 52):
            print "KING: you can place this card on your forehead"
            print "\tUntil this card drops, you can tell anyone to do anything you desire"
            print "\tYou cannot hold this card to your forehead, and the other players cannot physically touch it"
            print "\tIf another King is drawn, you must place this in the dead-pile"
        else:
            print "That wasn't one of the choices"

class Stages(object):

    def __init__(self, main_deck):
        self.main_deck = main_deck
        self.choices = range(0, 52)
        self.main_deck = self.choices

    def draw_stage(self):
        print "---------------------------------------------------------------"
        raw_input("Press enter to draw a card: ")

    def card_randomizer_stage(self):
        print "\nCard randomizers starts here"

        random.shuffle(self.choices)
        for i in range(1):
            self.random_card = self.choices[i]
            print "Random card # is: ", self.choices[i]
            self.choices.pop(i)

            return self.choices

    def card_action_stage(self):
        c = DeckOfCards(self.random_card)
        c.print_card()
        c.card_rules()


    def dead_pile_stage(self):
        pass

class Engine(object):

    def __init__(self, cardDeck):
        self.cardDeck = cardDeck

    def play(self):     # how to put this in a loop before I ever pass the deck?
        while self.cardDeck:
            b = Stages(self.cardDeck)
            b.draw_stage()
            b.card_randomizer_stage()
            b.card_action_stage()
            b.dead_pile_stage()


if __name__ == '__main__':
    main()
