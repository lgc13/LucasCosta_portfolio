from flask import Flask, render_template, request, session
from data import Rules
from game import gameEngine
import random

app = Flask(__name__)
cards_actions_list, deck_of_cards = Rules() # returning CARD_ACTIONS, a list from Rules()

@app.route('/')
@app.route('/index')
@app.route('/home')
def index():
    return render_template('home.html')

@app.route('/how_to_play')
def how_to_play():
    return render_template('how_to_play.html', card_actions_list = cards_actions_list)

# I'm dynamically creating pages for each card here depending on which was clicked 'c_index'
@app.route('/how_to_play/card_info/<int:c_index>/')
def card_info(c_index):
    return render_template('card_info.html', card_index = c_index, card_list = cards_actions_list)

@app.route('/about')
def about():
    return render_template('about.html')

@app.route('/start')
def start():
    return render_template('start.html')

@app.route('/start/create-players', methods=['POST'])
def create_players():
    number = int(request.form.get('players_amount'))
    return render_template('create_players.html', num_players = number)

@app.route('/play', methods=['POST'])
def play():
    # I can use the .getlist() to make this a list:
    names_list = request.form.getlist('players_names_list')
    session['username_list'] = request.form.getlist('players_names_list')
    set_user(session['username_list'])

    return render_template('play.html', names_list = names_list, username_list = session.get('username_list'))

def set_user(users_list):
    session['username_list'] = users_list
    return session['username_list']

def get_user(func):
    def inner():
        print(">>>>>>>>>>>>I'm in get_user()")
        return func()
    return inner



@app.route('/play/card_drawn')
@get_user
def card_drawn():

    # gameEngine(players_list, deck_of_cards)
    return render_template('card_drawn.html', deck = deck_of_cards, username_list = session.get('username_list'))




if __name__ == "__main__":
    app.secret_key = "super secret key"
    app.run(debug = True)
