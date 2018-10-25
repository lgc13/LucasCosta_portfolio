import MyClass
# from MyClass import User # I could have done this, so I don't have to type 'MyClass.User() everytime'

# if I had instanciated MyClass, I could do user1 = User('Lucas', 'Costa')
user1 = MyClass.User('Lucas', 'Costa')
user2 = MyClass.User('Jeff', 'Lname')

print user1.getName()
user1.test()
# createUser(b)
