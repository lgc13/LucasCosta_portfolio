from flask import Flask, render_template, request
from flask_sqlalchemy import SQLAlchemy
from sqlalchemy import text
from models.user import User

app = Flask(__name__)

POSTGRES = {
    'user': 'tlgc1',
    'pw': 'password',
    'db': 'tlgc1',
    'host': 'localhost',
    'port': '5432',
}
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://%(user)s:\
%(pw)s@%(host)s:%(port)s/%(db)s' % POSTGRES
# app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://tlgc1:password@localhost/tlgc1'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True

db = SQLAlchemy(app)



@app.route('/', methods=['POST', 'GET'])
def main():
    sql = text('SELECT * FROM ltable')
    result = db.engine.execute(sql)

    users = []

    for row in result:
        id = row[0]
        name = row[1]
        user = User(id, name)
        users.append(user)
        print('>>> Selected user:', user.getName())

    return render_template('index.html', users= users)

@app.route('/create', methods=['POST'])
def create():

    id = request.form.get('id')
    name = request.form.get('name')
    users = [User(id, name)]

    sql = text("INSERT INTO ltable VALUES (%s, '%s')" % (id, name))
    result = db.engine.execute(sql)

    return render_template('create.html', users= users)


if __name__ == "__main__":
    app.run(debug = True )
