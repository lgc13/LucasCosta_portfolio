
from sqlalchemy import text

class User():

    def __init__(self, name):
        print('>>> Instantiating object with name: %s' % (name))
        self.id = None
        self.name = name

    def insertUser(self, db):
        if self.id == None:
            print('>>> Inserting user into db')
            sql = text("INSERT INTO ltable (name) VALUES ('%s')" % self.name)
            result = db.engine.execute(sql)

            print('Result: %s' % result)

class UserActions():

    @staticmethod
    def getUsers(db):
        print('>>> Retrieving all users from DB')

        sql = text('SELECT * FROM ltable')
        result = db.engine.execute(sql)

        users = []

        for row in result:
            id = row[0]
            name = row[1]

            user = User(name)
            user.id = id
            users.append(user)

        return users
