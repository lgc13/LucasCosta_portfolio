# Learn Python the hard way
# Exercise 15: Reading Files
# 01/17/2017
print "LPTHW Practice"
print "E15: Reading Files"
print "Done by Lucas Costa"
print "Date: 01/19/2016"
print "Message: you can ask for an input while adding a note, like: raw_input(note)"
print ""

from sys import argv

script, filename = argv

txt = open(filename)

print "Here's your file %r:" % filename
print txt.read()

print "Type the filename again:"
file_again = raw_input("> ")

txt_again = open(file_again)

print txt_again.read()
