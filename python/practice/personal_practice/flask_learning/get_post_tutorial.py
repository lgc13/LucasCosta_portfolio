from flask import Flask, request # request will let us use POST method

app = Flask(__name__)

@app.route('/')
def index():
    return 'Homepage. Method used: %s' % request.method

@app.route('/post_example', methods=['GET', 'POST']) # by default, URLs will only handle GET. This will let us use POST methods
def post():
    if request.method == 'POST':
        return 'You are using the %s method' % request.method
    else:
        return 'You are probably using the %s method' % request.method

if __name__ == '__main__':
    app.run(debug = True)
