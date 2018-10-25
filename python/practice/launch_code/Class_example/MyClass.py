class User():
    print('Im in class')

    def __init__(self, username, password):
        self.username = username
        self._pass = password

    def setName(self, somename):
        self.username = somename

    def getName(self):
        return self.username


    def test(self):
        print('in test')

    a = 1 + 1
    print a

# a = MyClass()
# a.test()
