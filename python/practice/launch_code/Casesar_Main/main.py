from flask import Flask, render_template, request

app = Flask(__name__)

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/rotate', methods=['POST'])
def rotate():
    rotations = request.form.get('rotate_amount')
    text = request.form.get('text_input')
    return render_template('rotate.html', rotations = rotations, text = text)

if __name__ == "__main__":
    app.run(debug = True)
