#fizzBuzz
print('Welcome to Lucas Costa''s FizzBuzz 2018 program :D')
print('')

n = int(raw_input('Please input  your favorite number: '))

for i in range(n):
    if (i + 1) % 15 == 0:
        print('FizzBuzz')
    elif (i + 1) % 3 == 0:
        print('Fizz')
    elif (i + 1) % 5 == 0:
        print('Buzz')
    else:
        print i + 1
