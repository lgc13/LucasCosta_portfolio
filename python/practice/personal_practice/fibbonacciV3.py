def fib(n):
    if n == 0 or n == 1:
        return n
    return fib(n - 1) + fib(n - 2)

print("starting fibonacci v3")
n = input('What fibonacci number do you wanna find? ')
print(n)

# fib(2 - 1 = 1) + fib(2 - 2 = 0)
# fib(1) = 1 + fib(0) = 0, fib(2) = 1
#
# fib(3 - 1 = 2) + fib(3 - 2 = 1)
# fib(2) = 1 + fib(1) = 1, fib(3) = 2
#
# fib(4 - 1 = 3) + fib(4 - 2 = 2)
# fib(3) = 2 + fib(2) = 1, fib(4) = 3
