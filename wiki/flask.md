# Flask

## Structure

When creating a flask app structure, you can use `blueprints`. In order to do so, you should make different directories that will be `packages` (by having a `__init__.py` file within it, even if it's empty)

```sh
ProjectName
├── projectName
│   └── packageName # example: users
│       └── __init__.py
│       └── routes.py
│       └── forms.py
│       └── utils.py
│   └── packageName2 # example: posts
│       └── __init__.py
│       └── routes.py
│       └── forms.py
│   └── packageName3 # example: main
│       └── __init__.py
│       └── routes.py
```

routes.py has the following:

```python
from flask import Blueprint

users = Blueprint('users', __name__)

@users.route('/anyRoutesIWant')
def funtionNames():
  pass
```
