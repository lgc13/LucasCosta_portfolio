import itertools

def Rules():
    CARD_ACTIONS = [
        {
            'rank':'Ace',
            'rule': "Waterfall..Everyone Drinks"
        },
        {
            'rank':'2',
            'rule': "F**k you: Tell someone to drink"
        },
        {
            'rank':'3',
            'rule': "F**c me: You drink!"
        },
        {
            'rank':'4',
            'rule': "Floor: last person to touch the floor, drinks!"
        },
        {
            'rank':'5',
            'rule': "Guys: all men must toast"
        },
        {
            'rank':'6',
            'rule': "Chicks: all ladies must toast"
        },
        {
            'rank':'7',
            'rule': "Heaven: last peron to point up must drink"
        },
        {
            'rank':'8',
            'rule': "Date: pick someone. You must both drink together when the other drinks, until the end of the game"
        },
        {
            'rank':'9',
            'rule': "Rhyme: say a word which everyone must rhyme with, going around clockwise. The person who can't, drinks"
        },
        {
            'rank':'10',
            'rule': "Question Master: the person holding this card must always drink double. The only way to get rid of this card, is by asking someone a question. If they verbally answer the question(without another question) then they take this card. * If another 10 is drawn, put the old on in the dead-pile"
        },
        {
            'rank':'Jack',
            'rule': "Thumb Master: at any point, put your thumb on the table without saying anything. Everyone must do the same once you've done this. Last person to do it, drinks. You can continually do this until another Jack is pulled"
        },
        {
            'rank':'Queen',
            'rule': "Queen Rule: create a rule that must be obeyed for the entirety of the game by all players. Any other Queen Rules added will stack. If any Queen Rule is broken at any time, that person must drink. * Queen Rule cannot be overruled by anything, including a 'King'"
        },
        {
            'rank':'King',
            'rule': "KING: place this card on your forehead. Until it falls, you can tell anyone to do anything"
        }
    ]

    deck = list(itertools.product(['Ace', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King'],['Diamonds','Spades','Hearts','Clubs']))

    return CARD_ACTIONS, deck
