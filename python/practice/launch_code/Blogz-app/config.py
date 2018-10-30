POSTGRES = {
    'user': 'tlgc1',
    'pw': 'password',
    'db': 'tlgc1',
    'host': 'localhost',
    'port': '5432',
}

CREDENTIALS = 'postgresql://%(user)s:\
%(pw)s@%(host)s:%(port)s/%(db)s' % POSTGRES

# app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://tlgc1:password@localhost/tlgc1'
