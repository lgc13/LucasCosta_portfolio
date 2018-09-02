from flask import Flask, render_template

app = Flask(__name__)

@app.route('/shopping')
def shopping():
    shopping_list = ['Cheese', 'Steak', 'Chicken', 'Chocolate']
    return render_template("shopping.html", s_list = shopping_list) # passing in the list to HTML

if __name__ == '__main__':
    app.run(debug = True)
