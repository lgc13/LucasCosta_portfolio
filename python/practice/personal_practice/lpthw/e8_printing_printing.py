# Learn Python the hard way
# Exercise 7: Priting, Priting
# 10/14/2016

print "LPTHW Practice"  #comment
print "E8: Priting, Priting"
print "Done by Lucas Costa"
print "Date: 10/14/2016"
print "Message: writing it during class"

formatter = "%r %r \n%r %r"

result = formatter % (1, 2, 3, 4)
#filepath = "{}/{}.xslx".format("~", ""my_file_name")
print result
print formatter % ("one", "two", "three", "four")
print formatter % (True, False, False, True)
print formatter % (formatter, formatter, formatter, formatter)
print formatter % (
    "I had this thing",
    "That you could type up right",
    "But it didn't sing",
    "So I said goodnight"
)
