# learning more OOP

class DictClass(object):
    def __init__(self):  # setting initial funciton, with self.colors dict
        self.colors = {
            "red": "Best power ranger",
            "blue": "Sasha's fave"
        }                   # passing way#1: through self, in classes

    def printDict(self):        # passing in 'self'from init function. Using self.colors
        print "Color's list: ", self.colors['red']

    def anotherDict(self):    #creating another dict
        dict_2 = {
            "mcd": "Mcdonalds",
            "bk": "Burger King"
        }
        return dict_2      # returning the dict
    def printAnotherDict(self, food_dict):       #passing way #2: calling function from OUTSIDE class
        print "Food list: ", food_dict["mcd"]

    def printDict2FromClass(self):       # passing way #3: calling function from WITHIN class
        dict_4 = self.anotherDict()
        print "Another choice: ", dict_4['bk']

instance_variable = DictClass()     #creating an instance for the DictClass
instance_variable.printDict()       # running the printDict function with the instace created
dict_3 = instance_variable.anotherDict() #running anotherDict function, and setting the dict to a varuavke dict_3
instance_variable.printAnotherDict(dict_3) #passing in dict_3 into printAnotherDict
instance_variable.printDict2FromClass()  # running printDict2FromClass
