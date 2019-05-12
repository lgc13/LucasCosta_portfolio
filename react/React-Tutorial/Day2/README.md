# Day 2

## Styling, Conditional Rendering and Lists

Follow these [instructions](./conditionals-and-lists)

Demo:

![Demo](./conditionals-and-lists/demo.PNG)

## Class Component

Class components give you access to state.

Also, you can access props with `this.props.fieldName`

Here's how to convert the app from a functional component to a class component:

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
    return (
      <MainComponent
        superPeople={superPeople}
        restaurants={restaurants}
        onClick={handleClick}
      />
    );
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

- You can also create your own methods within the class, and call it in your component with ` this.methodName()`. Note that class method declarations must either start with `this.methodName` or use an arrow function:

```js
class Main extends React.Component {
  myCoolFunction() {
    // will not work
  }

  this.myCoolFunction() {
    // will work
  }

  myCoolFunction = () => {
    // will also work
  }
}
```

## State

[State & Lifecycle](https://reactjs.org/docs/state-and-lifecycle.html)

- State is similar to props, but it is private and fully controlled by the component. Props are immutable (cannot be changed)

- To use state, your class must have a constructor which calls super

- Constructors initialize values

- Super goes to the parent class (React.component), and imports its methods (example: this.setState())

``` js
// index.js
class Main extends React.Component {
  constructor(props) {
    super(props);
    this.state = {};
  }
  render() {
    return (
      <MainComponent
        superPeople={superPeople}
        restaurants={restaurants}
        onClick={handleClick}
      />
    );
  }
}
```

- Changing the state will change how things look in the screen (any child components using a state variable will be rerendered)

```js
// index.js
class Main extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      superPeople,
      restaurants,
      randomPerson: '',
      randomRestaurant: ''
    };
  }
  handleClick = () => {
    const { superPeople, restaurants } = this.state;
    let randomPerson = superPeople[Math.floor(Math.random() * superPeople.length)];
    let randomRestaurant = restaurants[Math.floor(Math.random() * restaurants.length)];
    this.setState({randomPerson, randomRestaurant});
  }
  render() {
    return (
      <MainComponent
        superPeople={this.state.superPeople}
        restaurants={this.state.restaurants}
        onClick={this.handleClick}
        randomPerson={this.state.randomPerson}
        randomRestaurant={this.state.randomRestaurant}
      />
    );
  }
}

// Randomizer.js
const Randomizer = (props) => {
  return (
    <div>
      <h3>Randomizer</h3>
      <button onClick={props.onClick}>
        Click me
      </button>
      {(props.randomPerson && props.randomRestaurant) &&
        <h4>{props.randomPerson.name} likes to eat at {props.randomRestaurant}</h4>}
    </div>
  );
}
```

## Lifecycle Methods

``` js
componentDidMount() {
// runs whenever you component is rendered for the first time
}

componentWillUnmount() {
// runs whenever the DOM component is removed
}
```

- Ex from docs: Creating a timer

componentDidMount() will set up the timer on render

componentWillUnmount() will tear down the timer (resetting the interval back)

- Full lifecycle:

Let’s quickly recap what’s going on and the order in which the methods are called:

1. When <Clock /> is passed to ReactDOM.render(), React calls the constructor of the Clock component. Since Clock needs to display the current time, it initializes this.state with an object including the current time. We will later update this state.

2. React then calls the Clock component’s render() method. This is how React learns what should be displayed on the screen. React then updates the DOM to match the Clock’s render output.

3. When the Clock output is inserted in the DOM, React calls the componentDidMount() lifecycle method. Inside it, the Clock component asks the browser to set up a timer to call the component’s tick() method once a second.

4. Every second the browser calls the tick() method. Inside it, the Clock component schedules a UI update by calling setState() with an object containing the current time. Thanks to the setState() call, React knows the state has changed, and calls the render() method again to learn what should be on the screen. This time, this.state.date in the render() method will be different, and so the render output will include the updated time. React updates the DOM accordingly.

5. If the Clock component is ever removed from the DOM, React calls the componentWillUnmount() lifecycle method so the timer is stopped.


## Lifting State Up

Taken from FB react [docs](https://reactjs.org/docs/lifting-state-up.html):

There should be a single “source of truth” for any data that changes in a React application. Usually, the state is first added to the component that needs it for rendering. Then, if other components also need it, you can lift it up to their closest common ancestor. Instead of trying to sync the state between different components, you should rely on the top-down data flow.

Lifting state involves writing more “boilerplate” code than two-way binding approaches, but as a benefit, it takes less work to find and isolate bugs. Since any state “lives” in some component and that component alone can change it, the surface area for bugs is greatly reduced. Additionally, you can implement any custom logic to reject or transform user input.

If something can be derived from either props or state, it probably shouldn’t be in the state. For example, instead of storing both celsiusValue and fahrenheitValue, we store just the last edited temperature and its scale. The value of the other input can always be calculated from them in the render() method. This lets us clear or apply rounding to the other field without losing any precision in the user input.


Open my [lifting-state-thermometer](./lifting-state-thermormeter) project to see this in action.

![Temperature Example](./lifting-state-thermormeter/temperature.gif)

## Practice

- Let's create 2 small apps using everything you just learned (class, components, state)

1. coin flip

- a small game where the user can choose heads or tails, and you will randomize the result, letting the user know whether they won or not

2. rock-paper-sizors

- similar to the coin flip, but this time the user can choose between rock, paper or scissors. You will randomize the result, letting the user know whether they won, lost, or if it was a tie.
