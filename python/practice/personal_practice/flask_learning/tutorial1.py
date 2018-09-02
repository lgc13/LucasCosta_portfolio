from flask import Flask

app = Flask(__name__) # this will help finding other files easier

# @ is a decorator, which is wrapping the def index()
@app.route('/') # this ties a URL to a python function. Ex: when they go to ('/'), routing will connect to the function directly below (def index())
def index(): # this is the index function for the router app.router('/')
    return 'Hello World! This is my first Flask app 2'

@app.route('/test/tuna')
def tuna():
    return '<h2>I dont like Tuna!!!!</h2>'  # using HTML

@app.route('/test/<username>') # using STRING variables on URL
def profile(username): # function name doesn't have to be the same as app.route
    return '<h3> Hello %s <h3>' % username # username will come from what was used in the URL

@app.route('/test/<int:some_number>') # using STRING variables on URL
def number(some_number):
    return '<h3> The number is: %s <h3>' % some_number # username will come from what was used in the URL

if __name__ == '__main__':
    app.run(debug = True) # this starts the app

# to run flask locally, you need to install it first (pip install flask)
# then, add 'debug = True' to your main app.run() so the page can auto refresh
# go to terminal and just file (ex: python file_name.py)
# you can now to to the browser, localhost:5000, and your index ('/' path) will open
