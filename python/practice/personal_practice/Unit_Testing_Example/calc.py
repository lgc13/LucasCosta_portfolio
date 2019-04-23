def add(numArray):
    result = 0
    for num in numArray:
        result = result + num
    return result

def subtract(x, y):
    return x - y

def multiply(x, y):
    return x * y

def divide(x, y):

    if y == 0:
        raise ValueError('Cannot divide by zero')
    return x / y
