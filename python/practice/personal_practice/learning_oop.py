# Learning OOP with Chris, Feb 23

class Drinks(object): # declaring a class, or a blueprint
    def __init__(self, name, ingredient):  # default constructor, that passes in parameters
        self.name = name  # set the passed in parameters to self.whatevers (instance variables)
        self.ingredient = ingredient
        # self.getDrunk() # I could do that, technically

    def getDrunk(self): #declare a function within a class, which brings "self" from __init__
        print "Your main drink is {}, which uses {}.".format(self.name, self.ingredient)



Drinks("Brazilian car bomb", "whiskey and irish cream").getDrunk()
#class("input").class1Function()
chrisFave = Drinks("Jack 'n Coke", "Jack Daniels and Cocaine")
#chrisFave is an instance of Drinks
chrisFave.getDrunk()

def printStuff():
    stuff = {
        "gf": "Sasha"
    }
    return stuff


sasha_name = printStuff() # run printStuff function and return 'stuff' dict. Set it = sasha_name
print "hi there,",sasha_name['gf']
