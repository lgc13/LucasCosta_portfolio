#interviewcake
"""
You have a list of integers, and for each index you want to find the product of every integer
except the integer at that index.
Write a function get_products_of_all_ints_except_at_index() that takes a list of integers and
returns a list of the products.

For example, given:

  [1, 7, 3, 4]

your function would return:

  [84, 12, 28, 21]

by calculating:

  [7 * 3 * 4,  1 * 3 * 4,  1 * 7 * 4,  1 * 7 * 3]

Do not use division in your solution.
"""
# notes
# get item on index 0, multiply indexs 1, 2, 3
# get item on index 1, multiply indexs 0, 2, 3
# get item on index 2, multiply indexs 0, 1, 3
# get item on index 3, multiply indexs 0, 1, 2
import numpy # not sure if I'm going to ues this


def get_products_of_all_ints_except_at_index(list_input):
    # write the body of your function here
    for index, number in enumerate(list_input):        # go through all elements in list_input
        list2 = []                                     # initializing list2 to put in new values
        [x*x for x in list2]
        print "hehe", list2

        for index2, number2 in enumerate(list_input):     # go through the other elements in list_input
            if index != index2:                       # only go through them when their index value aren't the same
                # new_value = number2
                # total_value = new_value * number2
                # new_value = number2
                # print "new value", new_value


                list2.append(number2)   # create a new list (probably not the most efficient way, then add number2 to it)


                # print "list2: ", list2
                # total_value = numpy.multiply(new_value, number2)
                # total_value = new_value * number2
                # print "total_value", total_value


            elif index == index2:
                pass
        print "list2 before multiply", list2
        # list2 * list2
        print "final list2 after    ", list2
        # numpy.multiply(list2)
        # list_input[index] = total_value
        print "\nlist1 (list_input)", list_input

    return "LIST ANSWERS: %s" % list_input



# run your function through some test cases here
# remember: debugging is half the battle!
list_input = [1, 7, 3, 4]
print get_products_of_all_ints_except_at_index(list_input)
