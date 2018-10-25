class User():

    print(">>> In user.py")

    def __init__(self, user_id, name):
        self.id = user_id
        self.name = name

    def getId(self):
        return self.id

    def getName(self):
        return self.name
