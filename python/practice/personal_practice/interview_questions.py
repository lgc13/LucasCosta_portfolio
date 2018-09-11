# How do you find the missing number in a given integer array of 1 to 100? (solution)
print 'Missing number questions'
def missing_number(ll):
    ll.sort()
    counter = 1
    print('Sorted list: %s' % ll)
    for i in range(len(ll)):
        # print 'hello'
        if ll[i] != counter:
            print counter
            counter = counter + 1
        counter = counter + 1

n_list = [1, 2, 5, 3, 7, 9]
missing_number(n_list)

# sort n_list
# get list length
# start counter at 1
# iterate through n_list
# if item != counter, add counter to list, or return it

#################################################################################
# How do you find the duplicate number on a given integer array?

print '\nFind duplicate questions'
def find_duplicate(list):
    list.sort()
    print 'Sorted list: %s' % list
    for i in range(len(list) - 1):
        if list[i] == list[i + 1]:
            print list[i]

int_list = [1, 1, 2, 3, 1, 5, 20, 100, 3]
find_duplicate(int_list)

# sort list
# iterate through list -1
# if this index item is == to the next one, then print it
#################################################################################
# How do you find the largest and smallest number in an unsorted integer array?

print '\nFind largest and smallest number in an array'

def largest_and_smallest(list):
    largest_number = -9999999999
    smallest_number = 9999999999
    for i in list:
        if i > largest_number:
            largest_number = i
        elif i < smallest_number:
            smallest_number = i
    print 'Largest number: %d' % largest_number
    print 'Smalelst number: %d' % smallest_number

int_list = [1, 5, -2, 3, 100]
largest_and_smallest(int_list)
#################################################################################

# How do you find all pairs of an integer array whose sum is equal to a given number?
print '\nFind pairs that add up to a given number'

def pair_sums(list, n):
    print 'full list: %s' % list
    for i in range(len(list)):
        print 'i is %d' % i
        print 'list[i] is %s' % list[i]
        for j in range(i + 1, len(list)):
            print 'list[j] is %s' % list[j]
            if list[i] + list[j] == n:
                print('These two numbers add up to %d: %d and %d' %(n, list[i], list[j]))


int_list = [1, 2, 3, 4]
pair_sums(int_list, 3)


# iterate through list
# check if an index + any other index == input number
# check if next index plus remaining indexes
# check if each index + every other index == input number
#################################################################################

# How do you find duplicate numbers in an array if it contains multiple duplicates?


# How are duplicates removed from a given array in Java? (solution)
# How is an integer array sorted in place using the quicksort algorithm? (solution)
# How do you remove duplicates from an array in place? (solution)
# How do you reverse an array in place in Java? (solution)
# How are duplicates removed from an array without using any library? (solution)
