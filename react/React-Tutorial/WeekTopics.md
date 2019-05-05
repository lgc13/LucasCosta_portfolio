QTP Intro to React Week plans:

# Day 1

- Wiki
- ES6
- Babel
- React: create-react-app
- JSX
- Components
- Props
- Practice (create 3 small apps)


-- move these to the right places
* Lifecycle of a component
* Handling events
* Conditional rendering
* Lists and keys
* Forms
* Lifting state up
* Composition vs Inheritance



-----------------

# Day 2

##. [State & Lifecycle](https://reactjs.org/docs/state-and-lifecycle.html)

- State is similar to props, but it is private and fully controlled by the component.

1. Creating classes

```js
// index.js
const superPeople = [
  {
    name: 'Thanos',
    power: 'The Snap'
  },
  {
    name: 'Iron Man',
    power: 'Intelligence x 3000'
  },
  {
    name: 'Dr Strange',
    power: 'the Time Stone'
  }
];

class Main extends React.Component {
  render() {
    return (<MainComponent superPeople={superPeople} />)
  }
}

// MainComponent.js
const MainComponent = (props) => (
  <div>
    <HelloEveryone superPeople={props.superPeople}/>
  </div>
)

// HelloEveryone.js
const HelloEveryone = (props) => {
  const listItems = props.superPeople.map((person) => (
    <p key={person.name}>{person.name} has {person.power}</p>)
  );
  return (
    <div>
      {listItems}
    </div>
  );
}
```

2. [Handling Events](https://reactjs.org/docs/handling-events.html)

3. [Conditional Rendering](https://reactjs.org/docs/conditional-rendering.html)

4. Afternoon

- Live coding demonstration
- Some time to tinker
- Reconvene for Q&A and day wrap-up


# Day 3

1. [Lists & Keys](https://reactjs.org/docs/lists-and-keys.html)

2. [Forms](https://reactjs.org/docs/forms.html)

3. [Lifting State Up](https://reactjs.org/docs/lifting-state-up.html)

4. [Composition vs Inheritance](https://reactjs.org/docs/composition-vs-inheritance.html)

5. [Thinking in React](https://reactjs.org/docs/thinking-in-react.html)

6. Afternoon

- Project overview
- Coding time
- Reconvene for questions and day wrap-up

# Day 4

1. Project status check, Q&A

2. Coding time

3. Reconvene for questions and day wrap-up


# Day 5

1. Project status check, Q&A

2. Coding time

3. Demos, code reviews, and final Q&A
