# Lucas Costa's Ring of Fire game, created Feb 27, 2017

class CardDeck(object):

    def __init__(self, card_type):
        self.card_type = card_type
        print "\nThe card you picked was: %s"  % self.card_type #why am I getting some random memory stuff?
        # make this line ^ another function
    def card_rules(self, card_type): # maybe I should use a dict for the cards
        if self.card_type == "2": # should I name this something else? something easier?
            print "Fuck you: You drink"
        # print self.card_type


class Stages(CardDeck):

    def draw_stage(self):
        print "The game starts here"
        print "Player X presses enter to draw a card"

    def card_randomizer(self):
        card_drawn = CardDeck("2")
        card_drawn.card_rules(self) # do I HAVE to pass something in? Does it have to be self?
        print "Card randomizers starts here"

    def card_action(self):
        pass

    def dead_pile(self):
        pass

class MainEngine(Stages):

    def __init__(self, game_start):   # should get rid of this
        self.game_start = game_start

    def play(self):
        Stages(self).draw_stage()
        Stages(self).card_randomizer()

# if __name__ == '__main__':
#     main()

MainEngine("hehahehasidh").play() # first part: init requires something.
# Stages("hi").draw_stage()

# Stages("bleh").card_randomizer()
