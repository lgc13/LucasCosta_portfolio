# React Unit Testing Example

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

4. To use `enzyme`, you must add 2 dependencies:

```sh
yarn add enzyme
yarn add enzyme-adapter-react-16 # same as your react version, found in the package.json
```

5. Create a `setupTests.js` file under your-app-name/src/ with the following:

```js
import { configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16'; // same version as you added

configure({ adapter: new Adapter() });
```
6. Here's a simple test:

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
