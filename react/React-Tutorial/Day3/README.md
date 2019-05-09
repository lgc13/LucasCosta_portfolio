# Day 3

## Handling events

[Read here](https://reactjs.org/docs/handling-events.html)

- React events are named using camelCase, rather than lowercase.

- With JSX you pass a function as the event handler, rather than a string.

```js
// HTML Example
<button onclick="activateLasers()">
  Activate Lasers
</button>

// React Example
<button onClick={activateLasers}>
  Activate Lasers
</button>
```

- You cannot return false to prevent default behavior in React

```js
function ActionLink() {
  function handleClick(e) {
    e.preventDefault();
    console.log('The link was clicked.');
  }

  return (
    <a href="#" onClick={handleClick}>
      Click me
    </a>
  );
}
```

- When using React you should generally not need to call addEventListener to add listeners to a DOM element after it is created. Instead, just provide a listener when the element is initially rendered.

- When you define a component using an ES6 class, a common pattern is for an event handler to be a method on the class. For example, this Toggle component renders a button that lets the user toggle between “ON” and “OFF” states:

```js
class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {isToggleOn: true};
  }
  handleClick = () => {
    this.setState(state => ({
      isToggleOn: !state.isToggleOn
    }));
  }
  render() {
    return (
      <div className="App">
        <div>
          <button onClick={this.handleClick}>
            Click me
          </button>
          <p> Current isToggleOn: {this.state.isToggleOn.toString()} </p>
        </div>
      </div>
    );
  }
}
```

- Ex of events with state

You can use arrow functions to do so:

```js
handleChange = (event) => {
    this.setState({ name: event.target.value });
 }
handleEnterPress = (event) => {
  if (event.key === 'Enter') {
    this.setState({
      ...this.state,
      name: '',
      people: [
        ...this.state.people,
        event.target.value
      ]
    });
  }
}

<p> Current Name: {this.state.name} </p>
<p> Current array of people: {this.state.people.map((person, index) => {
  if (index !== (this.state.people.length - 1)) {
    return `${person}, `;
  } else {
    return person;
  }
})} </p>
```
