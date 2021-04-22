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
import http from 'axios';
import { mocked } from 'ts-jest/utils';

jest.mock('axios'); // Step 1: mock all functions from given package

const mockHttpGet = mocked(http.get); // Step 2: create typescript mockable value

describe(getUsers.name, () => {
  it('calls the correct URL', () => {
    mockHttpGet.mockResolvedValue({ data: '' }); // Step 3: mock returned or resolved value of function
    getUsers();

    expect(mockHttpGet).toHaveBeenCalledWith('/api/users');
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

- You need use `async/await`

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

2. "Props/State" tests

- Important: although Enzyme allows you to test things such as state and props, you should not focus implementation details. 
- Instead, test what the end goal should be (what the user sees or interacts with)

For example

```typescript jsx
// WelcomeScreenWithProps.ts
const WelcomeScreenWithProps = ({ message }: { message: string }) => {
  return (
    <div>
      <div data-testid={'message'}>{message}</div>
    </div>
  );
};

// WelcomeScreenWithProps.test.ts
import React from 'react';
import { shallow } from 'enzyme';

describe(WelcomeScreenWithProps.name, () => {
  // BAD EXAMPLE WHEN USING CLASS COMPONENTS
  it('has the correct initial props', () => {
    const message = "I am a super cool message!"
    const wrapper = shallow(<WelcomeScreenWithProps message={message} />);

    expect(wrapper.props).toEqual({ message });
  });
  
  // GOOD EXAMPLE
  it('displays the proper initial message', () => {
    const message = "I am a super cool message!"
    const wrapper = shallow(<WelcomeScreenWithProps message={message} />);

    expect(wrapper.find({ 'data-testid': 'message' }).text()).toEqual(message);
  });
});



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

describe(WelcomeScreen.name, () => {
  // BAD EXAMPLE
  it('sets the initial message in state', () => {
    const useStateSpy = jest.spyOn(React, 'useState');

    shallow(<WelcomeScreen />);

    expect(useStateSpy).toHaveBeenCalledWith('Some message here...');
  });

  // BAD EXAMPLE WHEN USING CLASS COMPONENTS
  it('sets the initial message in state', () => {
    const wrapper = shallow(<WelcomeScreen />);
    
    expect(wrapper.state).toEqual({ message: 'Some message here...'})
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

3. Events test

- A user can click/submit/hover/... components on your UI. Enzyme allows you to simulate those events, so you can test the final result

```typescript jsx
// WelcomeScreen.ts
const WelcomeScreen = () => {
  const [message, setMessage] = useState('Some message here...');

  return (
    <div>
      <div data-testid={'message'}>{message}</div>
      <button onClick={() => setMessage("a different message!")}>Click Me!!!</button>
    </div>
  );
};

// WelcomeScreen.test.ts
import React from 'react';
import { shallow } from 'enzyme';

describe(WelcomeScreen.name, () => {
  // ... previous tests...

  describe('when button is clicked', () => {
    // Good example
    it('shows the new message', () => {
      const wrapper = shallow(<WelcomeScreen />)
      
      const button = wrapper.find('button') // Step 1: find the component
              
      button.simulate('click') // Step 2: simulate an event. * Note: events are props that start with `oN...`. 
      // Examples: 
      // onClick -> .simulate('click')
      // onSubmit -> .simulate('submit')
      // onCancel -> .simulate('cancel')
      // onCustomThingThatIJustMadeUp -> .simulate('customThingThatIJustMadeUp')
      
      expect(wrapper.find({ 'data-testid': 'message'})).toEqual("a different message!") // Step 3: expect
    });

    // Bad example when using class components
    it('calls setMessage in state', () => {
      const wrapper = shallow(<WelcomeScreen />)

      wrapper.find('button').prop('onClick')()
      
      expect(wrapper.state.setMessage).toHaveBeenCalled()
    });
  });
});

// Parent prop functions:

// WelcomeScreenWithProps.tsx
const WelcomeScreenWithProps = ({ message, handleClick }: { message: string, handleClick: () => void }) => {
  return (
      <div>
        <div data-testid={'message'}>{message}</div>
        <button onClick={handleClick}>Click me!</button>
      </div>
  );
};

// WelcomeScreenWithProps.test.tsx
import React from 'react';
import { shallow } from 'enzyme';

describe(WelcomeScreenWithProps.name, () => {
  describe('when button is clicked', () => {
    it("calls the parent's handleClick", () => {
      const handleClick = jest.fn() // mock the prop
      const wrapper = shallow(<WelcomeScreenWithProps message={"some message"} handleClick={handleClick} />)

      wrapper.find('button').simulate('click') 
      
      expect(handleClick).toHaveBeenCalledWith()
    });
  });
})
```

4. External data

- Most data that is not in the file being tested should be mocked. That individual data/functionality being provided should be unit tested on its own.

```typescript jsx
// WelcomeScreen.ts
import { useQuery } from 'react-query';
import { someApi } from './WelcomeApi';
import Loading from '../Loading';

const WelcomeScreen = () => {
  const { data: message, isLoading } = useQuery('getSomeData', someApi);

  return isLoading ? (
      <Loading />
  ) : (
      <div>
        <div data-testid={'message'}>{message}</div>
      </div>
  );
};

// WelcomeScreen.test.tsx
import React from 'react';
import { shallow } from 'enzyme';
import { useQuery } from 'react-query';
import { mocked } from 'ts-jest/utils';

jest.mock('react-query'); // Step 1: mock all functions from given package

const mockUseQuery = mocked(useQuery); // Step 2: create typescript mockable value

describe(WelcomeScreen.name, () => {
  // ... previous tests...

  describe('when data is still loading', () => {
    it('displays the loading icon', () => {
      mockUseQuery.mockReturnValue({ isLoading: true }) // Step 3: mock the returned value
      
      const wrapper = shallow(<WelcomeScreen />)
      
      expect(wrapper.find(Loading.name)).toHaveLength(1)
    });

    // alternative test
    it('does NOT display the message', () => {
      mockUseQuery.mockReturnValue({ isLoading: true }) // Step 3: mock the returned value

      const wrapper = shallow(<WelcomeScreen />)

      expect(wrapper.find({ 'data-testid': 'message' })).toHaveLength(0)
    });
  });

  describe('when data has been fetched', () => {
    it('displays the message', () => {
      mockUseQuery.mockReturnValue({ isLoading: false, data: 'I am a message!' }) // Step 3: mock the returned value

      const wrapper = shallow(<WelcomeScreen />)

      expect(wrapper.find({ 'data-testid': 'message' }).text()).toEqual('I am a message!')
    });

    it('does not display the loading icon', () => {
      mockUseQuery.mockReturnValue({ isLoading: false, data: 'I am a message!'  }) // Step 3: mock the returned value

      const wrapper = shallow(<WelcomeScreen />)

      expect(wrapper.find(Loading.name)).toHaveLength(0)
    });
  });
});
```

5. Async results

- if you make async calls, you can await your simulations so your state can rerender

```typescript jsx
// WelcomeScreen.ts
import http from 'axios';

const WelcomeScreen = () => {
  const [message, setMessage] = useState("I should show on first render")
  
  const handleUpdate = () => {
    axios.put('/api/messages').then(r => setMessage(r.data))
  }

  return (
      <div>
        <div data-testid={'message'}>{message}</div>
        <button onClick={handleUpdate}>Click me</button>
      </div>
  );
};

// WelcomeScreen.test.tsx
import http from 'axios';
import { mocked } from 'ts-jest/utils';

jest.mock('axios'); // Step 1: mock all functions from given package

const mockHttpPut = mocked(axios.put)

describe(WelcomeScreen.name, () => {
  it('shows the correct initial message', () => {
    const wrapper = shallow(<WelcomeScreen />)
    
    expect(wrapper.find({ 'data-testid': 'message' }).text()).toEqual("I should show on first render")
  });

  describe('when button is clicked', () => {
    it('makes http request', () => {
      const wrapper = shallow(<WelcomeScreen />)
      
      wrapper.find('button').simulate('click')
      
      expect(mockHttpPut).toHaveBeenCalledWith('/api/messages')
    });

    it('renders the new message', async () => { // Step 1: async function
      mockHttpPut.mockResolvedValue({ data: 'a new message' })
      const wrapper = shallow(<WelcomeScreen />)

      await wrapper.find('button').simulate('click') // Step 2: await simulation (http mock call)

      expect(wrapper.find({ 'data-testid': 'message' }).text()).toEqual('a new message' )
    });
  });
});
```
