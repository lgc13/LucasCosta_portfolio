# JSX, Components and Props

![Demo](./demo.gif)

## JSX

- Introducing [JSX](https://reactjs.org/docs/introducing-jsx.html)

1. JSK looks like HTML (although its not). Its available by importing from 'react'

2. Optional, not required

 ```js
 // Ex of react without JSK
 React.createElement('h1', /* ... h1 children ... */)
 ```

3. You cannot render more than 1 JSX element next to each other (in the same render return)

4. You CAN however, wrap elements within other elements. Ex: a <div> within another <div>

```js
// Allowed:
render() {
  return (
    <div>
      <p>Hello world!! I am wrapped</p>
      <h3> I am still wrapper </h3>
    </div>
  )
}

// Not allowed
render() {
  return (
    <p>Hello world!! I am wrapped</p>
    <h2>I am not wrapped</h2>
  )
}
```

5. You can only render built-in DOM components such as `<div>, <p>, <li>, etc` but you can create your own components with any name you want.

6. [JSX In-Depth](https://reactjs.org/docs/jsx-in-depth.html#why-jsx)

Some important points from the link above:

- User-Defined Components Must Be Capitalized

- Props Default to “True”

- Spread Attributes

## Components and Props

[Documentation - Click me!](https://reactjs.org/docs/components-and-props.html)

1. Components use XML-like syntax (JSX)

2. Can maintain its own internal state

3. Simple functional component:

```js
function HelloEveryone() {
  return (
    <div>
      <p>How you doin... </p>
    </div>
  );
}
```

``` js
// Component declaration with arrow function
const HelloEveryone = () => <div><p>How you doin... </p></div>
```

4. Render it:

```js
ReactDOM.render(
  <HelloEveryone />,
  document.getElementById("root")
);
```

5. You can also put this component in a separate file, export it, and import it in your main file

```js
// HelloEveryone.js
export default HelloEveryone;

// index.js
import HelloEveryone from './components/HelloEveryone.js'
```

6. Components can take JSX attributes, called props (short for properties)
```js
const HelloEveryone = (props) => <div><p>How you doin... {props.name} </p></div>

ReactDOM.render(
  <HelloEveryone name="Thanos" />,
  document.getElementById('root')
);
```

- note that the component must take a `props` argument.

7. Components can refer to other components:
```js
// index.js
ReactDOM.render(
  <MainComponent />,
  document.getElementById('root')
);

// MainComponent.js
const MainComponent = () => (
  <div>
    <HelloEveryone name="Thanos" />
    <HelloEveryone name="Iron Man" />
    <HelloEveryone name="Dr Strange" />
  </div>
)
```

8. Props are Read-Only

[Read here](https://reactjs.org/docs/components-and-props.html#props-are-read-only)

9. Passing multiple props, and deconstructing

``` js
// index.js
function Main() {
  return (
    <MainComponent
      superPeople={superPeople}
      restaurants={restaurants}
      onClick={handleClick}
    />
  )
}

const handleClick = () => {
  ReactDOM.render(
    <Main />,
    document.getElementById('root')
  );
}

handleClick(); // rendering when browser first starts

// MainComponent.js
<Randomizer
  superPeople={props.superPeople}
  restaurants={props.restaurants}
  onClick={props.onClick}
/>

// Randomizer.js
let randomPerson;
let randomRestaurant;

const randomize = (props) => {
  const { superPeople, restaurants } = props;
  randomPerson = superPeople[Math.floor(Math.random() * superPeople.length)];
  randomRestaurant = restaurants[Math.floor(Math.random() * restaurants.length)];
  props.onClick();
}

const Randomizer = (props) => {
  return (
    <div>
      <h3>Randomizer</h3>
      <button onClick={() => randomize(props)}>
        Click me
      </button>
      {(randomPerson && randomRestaurant) &&
        <h4>{randomPerson.name} likes to eat at {randomRestaurant}</h4>}
    </div>
  );
}
```
