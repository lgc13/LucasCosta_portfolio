# Learn Python the hard way
# Exercise 13: Parameters, Unpacking, Variables
# 01/17/2017
print "LPTHW Practice"
print "E13: Parameters, Unpacking, Variables"
print "Done by Lucas Costa"
print "Date: 01/19/2016"
print "Message: I just learned that %r is a pointer"
print ""

from sys import argv #sys is a module, or library

script, first, second, third = argv

print "The script is called:", script
print "Your first variable is:", first
print "Your second variable is:", second
print "Your third variable is:", third
