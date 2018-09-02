from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
@app.route('/<user>') # here we are mapping 2 different URLs to the same return template.
def index(user= None): # setting a default value for use variable as 'None'
    return render_template("user.html", u_name = user)

if __name__ == '__main__':
    app.run(debug = True)
