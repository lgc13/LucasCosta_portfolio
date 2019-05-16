# This page will are my notes for how to write Unit Tests

## Python

(You can see the example files used under python/practice/person_practice/Unit_Testing_Example)

1. Create your normal file that you want to be tested. Ex: `calc.py`
2. Create a 'test module' to test your file. This MUST BE named `test_filename.py`. In this case: `test_calc.py`
3. Import the unittest module, and the file to be tested, from within the test file.
(if this is a class being tested, then do it like: `from filename import Classname`)
4. Create a test class that inherits from unittest. Ex: `class TestCalc(unittest.TestCase)`
5. The methods MUST begin with `test`, but DON'T HAVE TO have the method name. Good examples: `def test_methodname(self)`. Ex: `def test_add(self)`

You can now use the Unittest assert methods from here:
https://docs.python.org/3/library/unittest.html#unittest.TestCase.debug

Ex: `self.assertEqual(calc.add(1, 2), 3)`

6. Add main function call to the test file:

```python
if __name__ == "__main__":
  unittest.main()
```

7. Make sure you are in the right environment, or using the correct python version (2 vs 3)
8. Run tests from terminal with `python test_filename.py`
9. You can use the `def setUp(self):` and the `def tearDown(self):` functions in the beginning of class tests to stay DRY

You can now create multiple 'edge case' tests. Ex: adding negative numbers, dividing by a negative or 0, passing in incorrect amount of parameters, etc.

-----------

## React

You can look at this project for examples: [unit-testing-example](../react/unit-testing-example)

- The following notes are expecting you to have used `yarn create react-app`

1. The `index.js` file should only render your App component.

   We will not test the component under index.test.js. This file COULD have tests for your ReactDom method

2. The `App.js` could be a basic file such as:

```js
import React from 'react';

const App = () => <p>Hello World!!!!</p>

export default App;
```

3. The `App.test.js` could be as such:

```js
import React from 'react';
import App from './App';

describe('App', () => {
  it('your test here', () => {});
});
```

4. To use `enzyme`, you must add it as a dependency:

   `yarn add enzyme`

5. Here's a simple test:

```js
import React from 'react';
import App from './App';
import { shallow } from 'enzyme';

describe('App', () => {
  it('exists', () => {
    const wrapper = shallow(<App />);
    expect(wrapper).toHaveLength(1);
  });
});
```

## React Native

I created a wiki separately for this. Check out this [readme](./react-native-testing.md)
