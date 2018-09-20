from flask import Flask, render_template, request
from data import Rules

app = Flask(__name__)
c_actions = Rules()

@app.route('/')
@app.route('/index')
@app.route('/home')
def index():
    return render_template('home.html')

@app.route('/how_to_play')
def how_to_play():
    return render_template('how_to_play.html', card_actions_list = c_actions)

@app.route('/how_to_play/card_info/<int:c_index>/')
def card_info(c_index):
    return render_template('card_info.html', card_index = c_index, card_list = c_actions)

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
    return render_template('play.html')




if __name__ == "__main__":
    app.run(debug = True)
