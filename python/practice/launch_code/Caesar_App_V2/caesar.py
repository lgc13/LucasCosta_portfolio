
def main():
    letters = 'abzABZ'
    rotation = 1
    for letter in letters:
        zero_base = alphabet_position(letter)
        rotate_character(zero_base, letter, rotation)

def alphabet_position(letter):
    print('>>>>Letter: %s' % letter)
    print('ASCII value: %d' % ord(letter))

    base = (ord(letter.upper()) - 65)
    print('0 base value: %d' % base)

    return base

def rotate_character(z_base, char, rot):
    if char == char.upper(): # only for uppercases
        # EXAMPLE: Z(z_base= 25, rot = 1) answer we want= A(65)
        new_base = (z_base + rot + 65)
        # (25 + 1) ...answer should be 65
        # (25 + 25) ... answer should be
        # I want my answer to be between 65 - 90
    else: # only for lowercases
        new_base = (z_base + rot + 97)

    new_letter = chr(new_base)
    print('   >>>>new_letter is %s' % new_letter)


if __name__ == "__main__":
    main()
