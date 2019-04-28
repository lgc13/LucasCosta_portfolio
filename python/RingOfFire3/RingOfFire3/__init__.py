from flask import Flask
from RingOfFire3.main.controllers import main
from RingOfFire3.admin.controllers import admin

app = Flask(__name__)

app.register_blueprint(main, url_prefix='/')
app.register_blueprint(admin, url_prefix='/admin')
