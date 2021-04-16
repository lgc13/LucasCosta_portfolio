# React Testing

- The following notes are expecting you to have used `yarn create react-app`

#### IntelliJ

- For better IntelliJ test colors and Eslint checks: [Go here > IntelliJ section](https://github.com/lgc13/LucasCosta_portfolio/blob/master/wiki/cheat-sheet.md#eslint--prettier)

### Jest - Function testing

- Raw JS can easily be tested with jest. Jest provides things such as: `expect, mock, describe, it, test` among others
- In React, we will use Jest when testing things such as your API calls, redux, helper functions, utils, etc.

- Some conventions:
   1. use `describe`s on top layer. Usually used with function, or component names
   2. use nested `describe`s to explain when/if cases
   3. use `it`s for each individual test
   4. if done right, a user should easily be able to find what's being tested, almost in a conversation-like manner:
    
   ```
  describe `functionName` to me
  | -> describe `functionName` when X thing happens
        | -> it returns A thing
  | -> describe `functionName` when Y thing happens
        | -> it returns B thing"
  | -> describe `functionName` when neither thing happens
        | -> it returns null"
   ```    

1. Basic example:

```typescript
// userUtils.ts
const areAllUsersAdminAndOlderThan30 = (users: User[]) => {
  const allUsersAreAdmin = users.every(user => user.role === 'admin');
  return allUsersAreAdmin ? users.every(user => user.age > 30) : false;
}

// userUtils.test.ts
describe(areAllUsersAdminAndOlderThan30.name, () => {
  describe('when all users are admin', () => {
    describe('when all users are over 30', () => {
      it('returns true', () => {
        const adminUser = { role: 'admin', age: 31 };
        const anotherAdminUser = { role: 'admin', age: 32 };
        const users = [adminUser, anotherAdminUser];

        expect(areAllUsersAdminAndOlderThan30(users)).toEqual(true);
      });
    });

    describe('when at least one user is under 30', () => {
      it('returns false', () => {
        const adminUser = { role: 'admin', age: 31 };
        const youngUser = { role: 'admin', age: 29 };
        const users = [adminUser, youngUser];

        expect(areAllUsersAdminAndOlderThan30(users)).toEqual(false);
      });
    });
  });

  describe('when at least one user is not an admin', () => {
    it('returns false', () => {
      const adminUser = { role: 'admin', age: 31 };
      const notAdminUser = { role: 'bad-role', age: 31 };
      const users = [adminUser, notAdminUser];

      expect(areAllUsersAdminAndOlderThan30(users)).toEqual(false);
    });
  });
});
```

2. Mocking

```typescript
// userAPI.ts
const getUsers = (): User[] => axios.get('/api/users').then(r => r.data)

// userApi.test.ts
import { areAllUsersAdminAndOlderThan30 } from './userApi'
import http from 'axios';
import { mocked } from 'ts-jest/utils';

jest.mock('axios'); // Step 1: mock all functions from given package

const mockHttpGet = mocked(http.get); // Step 2: create typescript mockable value

describe(getUsers.name, () => {
  it('calls the correct URL', () => {
    mockHttpGet.mockResolvedValue({ data: '' }); // Step 3: mock returned or resolved value of function
    getUsers();

    expect(http.get).toHaveBeenCalledWith('/api/users');
  });


  it('returns the data given from the API', () => {
    const user = { id: 1, name: 'lucas' }
    const users = [user, user]
    mockHttpGet.mockResolvedValue({ data: users }) // Step 3: mock returned or resolved value of function
    
    const result = getUsers()
    
    expect(result).toEqual(users)
  });
})
```

3. Async functions

- You should either use `async/await` or put your expects within `.then()`s

```typescript
// userAPI.ts
const getUsers = (): User[] => axios.get('/api/users').then(r => r.data)

// userApi.test.ts
// ... previous code

describe(getUsers.name, () => {
  // ... previous tests

  it('returns the data given from the API', async () => { // Step 1: async test
    const user = { id: 1, name: 'lucas' }
    const users = [user, user]
    mockHttpGet.mockResolvedValue({ data: users })
    
    const result = await getUsers() // Step 2: await async function call
    
    expect(result).toEqual(users)
  });
})
```

### Enzyme - Component testing

#### Set up

- create-react-app already comes with `jest` installed. You only need to add a component testing library. The two main options are:
    - [Enzyme](https://enzymejs.github.io/enzyme/)
    - [react-testing-library](https://testing-library.com/docs/react-testing-library/intro/)
- This tutorial will be using Enzyme

```sh
yarn add enzyme
yarn add enzyme-adapter-react-16 # same as your react version, found in the package.json
```

- Create a `setupTests.js` file under your-app-name/src/ with the following:

```js
import { configure } from 'enzyme';
import Adapter from 'enzyme-adapter-react-16'; // same version as you added

configure({ adapter: new Adapter() });
```

- Enzyme is very powerful and allows you to "render" your component. You can then look for tags in your dom. It can also trigger state effects, among other things.
  
1. Basic test

```typescript jsx
// WelcomeScreen.ts
const WelcomeScreen = () => (
  <div>
    <div data-testid={"message"}>Hello there!</div>
  </div>
)

// WelcomeScreen.test.ts
import React from 'react';
import { shallow } from 'enzyme';

describe(WelcomeScreen.name, () => {
  it('greets the user', () => {
    const wrapper = shallow(<Welcome />)
    
    expect(wrapper.find({ 'data-testid': 'message' })).toEqual('Hello there!')
  });
});
```

- Important: although Enzyme allows you to test things such as state and props, you should not focus implementation details. 
- Instead, test what the end goal should be (what the user sees or interacts with)

For example

```typescript jsx
// WelcomeScreen.ts
const WelcomeScreen = () => {
  const [message, setMessage] = React.useState('Some message here...');

  return (
          <div>
            <div data-testid={'message'}>{message}</div>
          </div>
  );
};

// WelcomeScreen.test.ts
import React from 'react';
import { shallow } from 'enzyme';

describe('WelcomeScreen', () => {
  // BAD EXAMPLE
  it('sets the initial message in state', () => {
    const useStateSpy = jest.spyOn(React, 'useState');

    shallow(<WelcomeScreen />);

    expect(useStateSpy).toHaveBeenCalledWith('Some message here...');
  });

  // GOOD EXAMPLE
  it('displays the proper initial message', () => {
    const wrapper = shallow(<WelcomeScreen />);

    expect(wrapper.find({ 'data-testid': 'message' }).text()).toEqual(
            'Some message here...',
    );
  });
});
```


