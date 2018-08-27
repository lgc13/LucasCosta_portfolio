import random
import numpy as np

dice = []
diceMaxLength = 5
scoreBoard = []

welcomeLog =  """
Welcome to our Yahtzee game!
This is our project for HackFSU, 2017
Our team is made up of Lucas Costa, Sasha Larson and Devesh Waingakar"""

def main():
    print welcomeLog
    while True:
        try:
            numberOfPlayers = int(raw_input("\nPlease enter how many players there are: "))
        except ValueError:
            print "Please enter a numeric value"
            continue
        else:
            break
        #showScoreBoard(numberOfPlayers)
    names = playersCount(numberOfPlayers)
    firstRoll(names, numberOfPlayers)
    #rand()

def playersCount(numberOfPlayers):  #ask how many players there are, get their names. return playerNames

    playerNames = []

    print "That's awesome! Let's get everyone's names..."
    for index in range(0, numberOfPlayers):
        nameInput = raw_input("Player %s, please enter your name: " % (index + 1))
        playerNames.append(nameInput)

    print "Great! Here are all the players: "
    for index, name in enumerate(playerNames):
        print "%s: %s" % (index + 1, name)
    print "Good luck to the %s of you!" % numberOfPlayers
    return playerNames

def firstRoll(names, numberOfPlayers):   #allow players to start, calling them by name
    for i in names:
        raw_input("\n%s: it's your turn. Press ENTER to roll the dice" % i)
        for i in range(diceMaxLength):
            dice.append(random.randint(1,6))
        print dice

        scores = bubblesort(dice)
        choice = raw_input("\nPress ENTER to continue, or z to keep your score ")
        if choice == 'z':
            # showScoreBoard(numberOfPlayers, names, sc_choice, score)
            sc_choice = score()
            scores = bubblesort(dice)
            showScoreBoard(numberOfPlayers, names, sc_choice, scores)
        else:
            rollagain(dice)
            print dice
            choice1 = raw_input("\nPress ENTER to continue, or z to keep your score ")
            if choice1 == 'z':
                # showScoreBoard(numberOfPlayers, names, sc_choice, score)
                sc_choice = score()
                scores = bubblesort(dice)
                showScoreBoard(numberOfPlayers, names, sc_choice, scores)
            else:
                rollagain(dice)
                print dice
                sc_choice = score()
                scores = bubblesort(dice)
                showScoreBoard(numberOfPlayers, names, sc_choice, scores)


def rollagain(dice):
    # while True:  #this while statement doesn't take into account multiple indexes (lines 76-80)
    #     try:
    #
    #     except ValueError:
    #         print "Please enter an index. Ex: 1, 2, 3 or 4"
    #         continue
    #     else:
    #         break
    i = raw_input("Choose indexes of the dice you want to REROLL separated by commas: ")
    new_i = [ int(k) for k in i.split(",")]
    new_i = np.array(new_i) - 1
    for index in new_i:
        dice[index] = np.random.randint(1,7)
    dice #wtf is this here for?!!?!?


    """check for any possible combos
    allow user to do one of the following:
        1- reroll dice
        2- end turn, and choose score
            2.1 - show player any available combos to pick from, along with scoreboard
            2.2 - ask which score they want to keep or remove
    """

def score():
    sc_choice = raw_input("Enter the choice of score you would like to be considered: ")
    return sc_choice

def showScoreBoard(numberOfPlayers, names, sc_choice, scores):
    print "\n\t--- SCOREBOARD ---"
    scoreBoard = [[' ' for i in range(numberOfPlayers + 2)] for j in range(16)]
    for i in range(1, 15):
        scoreBoard[i][0] = i
    for j in range(numberOfPlayers + 1):
        scoreBoard[0][j] = names
    scoreBoard[1][numberOfPlayers - 1]= scores
    # for k in range(1, 15):


    scoreBoard[0][0] = "Entry #"
    scoreBoard[0][1] = "Possibilites"
    scoreBoard[1][1] = "One's"
    scoreBoard[2][1] = "Two's"
    scoreBoard[3][1] = "Three's"
    scoreBoard[4][1] = "Four's"
    scoreBoard[5][1] = "Five's"
    scoreBoard[6][1] = "Bonus"
    scoreBoard[7][1] = "Subtotal"
    scoreBoard[8][1] = "Pair"
    scoreBoard[9][1] = "3 of a kind"
    scoreBoard[10][1] = "4 of a kind"
    scoreBoard[11][1] = "Full house"
    scoreBoard[12][1] = "Straight"
    scoreBoard[13][1] = "Chance"
    scoreBoard[14][1] = "Yahtzee"
    scoreBoard[15][1] = "Total"


    for row in scoreBoard:
        print ''.join(['%12s' % i for i in row])


# def rand():
#     for i in range(5):
#         dice.append(random.randint(1,6))
#     print dice

def winner(dice):
    k = 0
	#Yahtzee
    if dice[0] == dice[1] and dice[0] == dice[2] and dice[0] == dice[3] and dice[0] == dice[4]:
	    print "YAHTZEE!"
	    winnerIndex = 50
	#     #Four of a kind roll possibilites

    elif dice[0] == dice[1] and dice[0] == dice[2] and dice[0] == dice[3] and dice[0] != dice[4]:
	    print "You have four of a kind"
	    winnerIndex = dice[0] + dice[1] + dice[2] + dice[3]

    elif dice[0] == dice[1] and dice[0] == dice[2] and dice[0] != dice[3] and dice[0] == dice[4]:
        print "You have four of a kind"
        winnerIndex = dice[0] + dice[1] + dice[2] + dice[4]

    elif dice[0] == dice[1] and dice[0] != dice[2] and dice[0] == dice[3] and dice[0] == dice[4]:
        print "You have four of a kind"
        winnerIndex = dice[0] + dice[1] + dice[4] + dice[3]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[0] == dice[2] and dice[0] == dice[3] and dice[0] == dice[4]:
        print "You have four of a kind"
        winnerIndex = dice[0] + dice[4] + dice[2] + dice[3]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[1] == dice[2] and dice[1] == dice[3] and dice[1] == dice[4]:
        print "You have four of a kind"
        winnerIndex = dice[4] + dice[1] + dice[2] + dice[3]
        #print winnerIndex

    #Three of a kind possibilites
    elif dice[0] != dice[1] and dice[0] != dice[2] and dice[0] == dice[3] and dice[0] == dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[0] + dice[3] + dice[4]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[0] == dice[2] and dice[0] != dice[3] and dice[0] == dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[0] + dice[2] + dice[4]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[0] == dice[2] and dice[0] == dice[3] and dice[0] != dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[0] + dice[2] + dice[3]
        #print winnerIndex

    elif dice[0] == dice[1] and dice[0] != dice[2] and dice[0] != dice[3] and dice[0] == dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[0] + dice[1] + dice[4]
        #print winnerIndex

    elif dice[0] == dice[1] and dice[0] != dice[2] and dice[0] == dice[3] and dice[0] != dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[0] + dice[1] + dice[3]
        #print winnerIndex

    elif dice[0] == dice[1] and dice[0] == dice[2] and dice[0] != dice[3] and dice[0] != dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[0] + dice[1] + dice[2]
        #print winnerIndex

    elif dice[4] == dice[3] and dice[4] == dice[2] and dice[4] != dice[1] and dice[4] != dice[0]:
        print "You have three of a kind"
        winnerIndex = dice[4] + dice[2] + dice[3]
        #print winnerIndex

    elif dice[4] == dice[3] and dice[4] != dice[2] and dice[4] == dice[1] and dice[4] != dice[0]:
        print "You have three of a kind"
        winnerIndex = dice[4] + dice[1] + dice[3]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[1] == dice[2] and dice[1] == dice[3] and dice[1] != dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[1] + dice[2] + dice[3]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[1] == dice[2] and dice[1] != dice[3] and dice[1] == dice[4]:
        print "You have three of a kind"
        winnerIndex = dice[1] + dice[2] + dice[4]
        #print winnerIndex

    #Pair roll possibilites
    elif dice[0] != dice[1] and dice[0] != dice[2] and dice[0] != dice[3] and dice[0] == dice[4]:
        print "You have a pair"
        winnerIndex = dice[0] + dice[2]
        #print winnerIndex

    elif dice[0] == dice[1] and dice[0] != dice[2] and dice[0] != dice[3] and dice[0] != dice[4]:
        print "You have a pair"
        winnerIndex = dice[0] + dice[1]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[0] == dice[2] and dice[0] != dice[3] and dice[0] != dice[4]:
        print "You have a pair"
        winnerIndex = dice[0] + dice[2]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[0] != dice[2] and dice[0] == dice[3] and dice[0] != dice[4]:
        print "You have a pair"
        winnerIndex = dice[0] + dice[3]
        #print winnerIndex
    elif dice[0] != dice[1] and dice[1] != dice[2] and dice[1] != dice[3] and dice[1] == dice[4]:
        print "You have a pair"
        winnerIndex = dice[1] + dice[4]
        #print winnerIndex
    elif dice[4] != dice[3] and dice[4] == dice[2] and dice[4] != dice[1] and dice[4] != dice[0]:
        print "You have a pair"
        winnerIndex = dice[4] + dice[2]
        #print winnerIndex

    elif dice[4] == dice[3] and dice[4] != dice[2] and dice[4] != dice[1] and dice[4] != dice[0]:
        print "You have a pair"
        winnerIndex = dice[4] + dice[3]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[1] == dice[2] and dice[1] != dice[3] and dice[1] != dice[4]:
        print "You have a pair"
        winnerIndex = dice[1] + dice[2]
        #print winnerIndex

    elif dice[4] != dice[3] and dice[3] == dice[2] and dice[3] != dice[1] and dice[3] != dice[0]:
        print "You have a pair"
        winnerIndex = dice[3] + dice[2]
        #print winnerIndex

    elif dice[0] != dice[1] and dice[1] != dice[2] and dice[1] == dice[3] and dice[1] != dice[4]:
        print "You have a pair"
        winnerIndex = dice[1] + dice[3]
        #print winnerIndex

    elif dice == [1, 2, 3, 4, 5]:
    	    print "You have a straight"
            winnerIndex = 20
    	    #print winnerIndex


    #Fullhouse
    elif dice[0] == dice[1] and dice[0] == dice[2] and dice[3]== dice[4] and dice[0]!=dice[3]:
        print "Fullhouse"
        winnerIndex = dice[0] + dice[1] + dice[2] + dice[3] + dice[4]
        #print winnerIndex
    elif dice[2] == dice[3] and dice[2] == dice[4]:
        k=1
    elif dice[0] == dice[1] and k == 1 and dice[0] != dice[3]:
        #print "Fullhouse"
        winnerIndex = dice[0] + dice[1] + dice[2] + dice[3] + dice[4]
    else:
        print "TOo bad, so sad"
    return winnerIndex


#Straight rolls possibilites
#there are only 5 die so you need to write it all out... damn it
def bubblesort(dice):
    a = dice
    for i in range(0, len(a) - 1):
	for j in range(0, len(a) - 1 - i):
	    if a[j] > a[j+1]:
	        a[j], a[j+1] = a[j+1], a[j]

    # dice = dice
    scores = winner(dice)
    print scores
    return scores

if __name__ == '__main__':
    main()
