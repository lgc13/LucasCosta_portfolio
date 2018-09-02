from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return 'This is the homepage'

@app.route('/profile/<username>')
def profile(username):
    return render_template("profile_page.html", user_name = username) # here we are calling the profile_page.html template within the 'templates' directory, and setting the local variable 'username' to be used in the template as 'user_name'

if __name__ == '__main__':
    app.run(debug = True)

# By default, Flask will expect any templates to be in a folder called 'templates' within the same directory
# Any static files (css, js) would be found in the 'static' directory

# To add CSS, you need to use the url_for() in the html file
