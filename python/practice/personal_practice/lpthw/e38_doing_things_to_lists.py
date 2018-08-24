# Learn Python the hard way
# Exercise 38: Doing Things to Lists

print "LPTHW Practice"
print "E38: Doing Things to Lists"
print "Done by Lucas Costa"
print "Date: 02/15/2016"
print "while loops are written as while i < x:"
print ""

ten_things = "Apples Oranges Crows Telephone Light Sugar"

print "Wait there are not 10 things in that list. Let's fix that "

stuff = ten_things.split(' ')
more_stuff = ["Day", "Night", "Song", "Frisbee", "Corn", "Banana", "Girl", "Boy"]

while len(stuff) != 10:
    next_one = more_stuff.pop()
    print "Adding: ", next_one
    stuff.append(next_one)
    print "There are %d items now." % len(stuff)

print "There we go: ", stuff

print "Let's do some thigns with stuff."

print stuff[1]
print stuff[-1] #whoa?! fancy?!
print stuff.pop()
print ' '.join(stuff) #what? cool
print '#'.join(stuff[3:5]) # super stellar
