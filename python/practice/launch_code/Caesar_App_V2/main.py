from flask import Flask, render_template, request

app = Flask(__name__)

@app.route('/', methods=['GET', 'POST'])
@app.route('/home')
def home():
    if request.method == 'GET':
        return render_template('index.html')
    elif request.method == 'POST':
        return render_template('about.html')

@app.route('/home/about', methods=['POST'])
def about():
    rot_amount = request.form.get("rotation-amount")
    new_text = request.form.get("block-text")
    ## TODO:
    # run caeser algorithm
    # receive back a list|string| whatever you want with the answer
    return render_template('about.html', rot = rot_amount, b_text = new_text)

app.run(debug = True)
