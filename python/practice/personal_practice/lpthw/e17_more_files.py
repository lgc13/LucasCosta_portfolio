# Learn Python the hard way
# Exercise 17: More Files
# 01/25/2017
print "LPTHW Practice"
print "E17: More Files"
print "Done by Lucas Costa"
print "Date: 01/25/2016"
print "Message: opening a file with \"filename, w\" lets you write on the file"
print ""

from sys import argv
from os.path import exists

script, from_file, to_file = argv

print "Copying from %s to %s" % (from_file, to_file)

# we could do these two on one line, how?
in_file = open(from_file)
indata = in_file.read()

print "The input file is %d bytes long" % len(indata)

print "Does the output file exists? %r" % exists(to_file)
print "Ready, hit RETURN to continue, CTRL-C to abort."
raw_input()

out_file = open(to_file, 'w')
out_file.write(indata)

print "Alright, all done."

out_file.close()
in_file.close()
