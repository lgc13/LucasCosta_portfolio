# Learn Python the hard way
# Exercise 33: While Loops

print "LPTHW Practice"
print "E33: While Loo[s]"
print "Done by Lucas Costa"
print "Date: 02/15/2016"
print "for loops: for i in range(x, y):"
print ""

i = 0
numbers = []

while i < 6:
    print "At the top i is %d" % i
    numbers.append(i)

    i = i + 1
    print "Numbers now: ", numbers
    print "At the bottom i is %d" % i


print "The numbers: "

for num in numbers:
    print num 
