# Python code
# this is meant to summarize code that I've learned over time in Python
# so that I can easily find it all in one place

print "Python code stuff:\n"

tab_howto = "\tUse \\t to tab" # \\ is an 'escape sequence'
ask_forInput = "Use 'raw_input()' to ask for input"
first_line = "long"
second_line = "longer"


print tab_howto
print ask_forInput
name_input = raw_input("Ex: name_input = raw_input() enter your name: ")
print "Your input above was: %r" % (name_input) #this is a pointer
print "You can use pointers to print out (%r is for debugging and %s is for display)"
print "You can use 'print_all' to print stuff from a file"
print "You can return things, like equations"
if first_line != second_line:
    print "Using an if statement to print this"
print "A for loop is written as for i in range(x, y): "
for i in range(0,6):
    print "For loop numbers: %s" % i
i = 0
while i < 6:
    print "Writing a for loop:"
    print "\tFirst number is: %s" % i
    i = i + 1
