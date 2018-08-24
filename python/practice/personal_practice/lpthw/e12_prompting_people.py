# Learn Python the hard way
# Exercise 12: Prompting Peoples
# 01/17/2017
print "LPTHW Practice"
print "E12: Prompting People"
print "Done by Lucas Costa"
print "Date: 01/18/2016"
print "Message: learning python makes me a bit sleepy"
print ""

age = raw_input("How old are you? ")
height = raw_input("How tall are you? ")
weight = raw_input("How much do you weigh? ")

print "So, you're %r old, %r tall and %r." % (
    age, height, weight)
