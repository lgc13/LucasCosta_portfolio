from flask import Flask, render_template, request, flash, redirect, url_for
from models.user import User, UserActions
from flask_sqlalchemy import SQLAlchemy
import config

app = Flask(__name__)

app.secret_key = 'super secret key'
app.config['SQLALCHEMY_DATABASE_URI'] = config.CREDENTIALS
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True

db = SQLAlchemy(app)
userActions = UserActions()

@app.route('/', methods=['POST', 'GET'])
def main():
    if request.method == 'GET':
        users_list = userActions.getUsers(db)

    return render_template('index.html', users= users_list)

@app.route('/success', methods=['POST'])
def success():
    if request.method == 'POST':
        name = request.form.get('name')

        new_user = User(name) # create a user object
        try:
            userActions.insertUser(db, new_user) # insert user into DB
        except:
            flash('Could not insert user into DB')
            return redirect(url_for('main'))

        users_list = userActions.getUsers(db) # get updated list of users

    return render_template('index.html', users= users_list)

if __name__ == "__main__":
    app.run(debug = True )
