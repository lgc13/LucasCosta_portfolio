def remove_vowels(fullname):
    words_no_spaces = fullname.split(' ') # split all words by spaces, into a list called words_no_spaces
    #print('all words', words_no_spaces)
    answer = "" # initialize variable answer blank
    for words in words_no_spaces:
        if words != '':
            #print('words: ', words)
            answer = answer + words[0].upper()

    return answer

def main():
    print(remove_vowels("test a"))
    print(remove_vowels("  tet b b    "))

if __name__ == "__main__":
    main()
