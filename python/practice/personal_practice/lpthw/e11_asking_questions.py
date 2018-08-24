# Learn Python the hard way
# Exercise 11: Asking Questions
# 01/17/2017
print "LPTHW Practice"
print "E11: Asking Questions"
print "Done by Lucas Costa"
print "Date: 01/18/2016"
print "Message: using \\n escape sequences for make new lines instead ;)"
print ""

print "How old are you?",
age = raw_input()
print "How tall are you?",
height = raw_input()
print "How much do you weigh?",
weight = raw_input()

print "So, you're %r old, %r tall and %r heavy." % (age, height, weight)
