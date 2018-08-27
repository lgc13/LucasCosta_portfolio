x = 'some text$$$$$$$$$$'
counter_var = 0

for i in x:
    print('i is %s' % i)
    if i.isalpha():
        counter_var= counter_var + 1

print("counter_var value is: %d" % counter_var)
