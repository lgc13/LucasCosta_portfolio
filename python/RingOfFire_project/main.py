from flask import Flask, render_template, request
from data import Rules
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
    # for name in names_list:
    #     print(name)
    return render_template('play.html', names_list = names_list)

@app.route('/play/card_drawn')
def card_drawn():
    return render_template('card_drawn.html', deck = deck_of_cards)




if __name__ == "__main__":
    app.run(debug = True)
