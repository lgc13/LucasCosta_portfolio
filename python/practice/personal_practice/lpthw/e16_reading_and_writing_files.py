# Learn Python the hard way
# Exercise 16: Reading and Writing Files
# 01/17/2017
print "LPTHW Practice"
print "E16: Reading and Writing Files"
print "Done by Lucas Costa"
print "Date: 01/25/2016"
print "Message: you can open a file with: open(filename)"
print ""

from sys import argv

script, filename = argv

print "We're going to erase %r." % filename
print "If you don't want that, hit CTRL-C (^C)."
print "If you do want that, hit ENTER"

raw_input("?")

print "Opening the file..."
target = open(filename, 'w')

print "Truncating the file. Goodbye!"
target.truncate()

print "Now I'm going to ask you for three lines."

line1 = raw_input("line 1: ")
line2 = raw_input("line 2: ")
line3 = raw_input("line 3: ")

print "I'm going to write these to the file"

target.write(line1)
target.write("\n")
target.write(line2)
target.write("\n")
target.write(line3)
target.write("\n")

print "And finally, we close it"
target.close()
