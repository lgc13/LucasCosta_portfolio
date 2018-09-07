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

@app.route('/start', methods=['GET', 'POST'])
def start():
    if request.method == 'GET':
        return render_template('start.html')
    elif request.method == 'POST':
        f_name = request.form.get('firstname')
        l_name = request.form.get('lastname')
        return render_template('play.html', fname = f_name, lname = l_name)



# @app.route('/play', methods=['GET', 'POST'])
# def play():
#     f_name = request.form.get('firstname')
#     l_name = request.form.get('lastname')
#     return render_template('play.html', fname = f_name, lname = l_name)

if __name__ == "__main__":
    app.run(debug = True)
