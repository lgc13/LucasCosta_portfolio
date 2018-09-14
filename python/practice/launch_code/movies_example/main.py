from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
@app.route('/index')
def hello():
    return 'hello'

@app.route('/thomas')
def thomas():
    return '<h1>hello from thomas</h1>'

@app.route('/movies')
def movies():
    movies_list = ['Blade Runner', 'Spider Man', 'Waking Life']
    
    return render_template('movies.html', m_list = movies_list)

# print(hello())

if __name__ == "__main__":
    app.run(debug = True)
