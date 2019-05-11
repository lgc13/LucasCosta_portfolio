# Day 1 topics

## Install Yarn

This can be time consuming, so let's get it started and move on to the next few topics.

1. Install Brew

Check if you already have it installed:

`brew -version`

If you don't, install it from here: https://brew.sh/

2. Install Node

Check if you already have it installed

`node --version`

If you don't have it installed, go ahead and install it now:

`brew install node`

3. Install Yarn

Check if you already have it installed

`yarn --version`

If you don't have it, first try installing it with brew:

`brew install yarn`

If that doesn't work, then install it from this link: [Yarn](https://yarnpkg.com/latest.msi)

If necessary, here's Node's link: [Node.js](https://nodejs.org/en/)

## Wiki

Talk about why/how to create and use one.

## ES6

Let's create a folder with a HTML and JS file, to play around with everything mentioned below.

Read about it [here](https://codeburst.io/javascript-wtf-is-es6-es8-es-2017-ecmascript-dca859e4821c)

Put simply, ECMAScript is a standard. While JavaScript is the most popular implementation of that standard. JavaScript implements ECMAScript and builds on top of it

[Features of ES6](http://exploringjs.com/es6/ch_overviews.html)

Some common used ones:

- Usage of const/let vs var
```js
let name = 'lucas';
name = 'sasha'; // allowed

const lastName = 'costa';
lastName = 'gomes'; // not allowed
```

- for of loop
```js
const colors = ['red', 'blue', 'green', 'purple'];

for (let color of colors) {
  console.log(color); // prints out each individual color
}
for (const [index, element] of colors.entries()) {
    console.log(`${index}. ${element}`); // prints out each index, then the color
}
```

- Arrow functions

Also called fat arrows. They are similar to lambdas in Python/C#. This allows you to NOT type `function`, ` return`(this is implicit in arrow functions), and curly braces.


Read more [here](https://www.sitepoint.com/es6-arrow-functions-new-fat-concise-syntax-javascript/)

``` js
// ES5
var multiplyES5 = function(x, y) {
  return x * y;
};
multiplyES5(1, 3);

// ES6 (note the curly braces are not required)
const multiplyES6 = (x, y) => { return x * y };
multiplyES6(5, 6);
```

- Array manipulation methods (available from ES5 but worth mentioning)

```js
const persons = [
  {
    id: 1,
    name: "Lucas",
    mood: "Hungry"
  },
  {
    id: 2,
    name: "Sasha",
    mood: "Excited"
  },
  {
    id: 3,
    name: "David",
    mood: "Uncaffeinated"
  }
];
// find
let result = persons.find(person => person.id === 1);
console.log('Result with id of 1: ', result);

// filter
let peopleHungry = persons.filter(person => person.mood === "Hungry");
console.log("People hungry: ", peopleHungry);

// forEach
persons.forEach(person => console.log(person.name));

// map
  // ES5
result = persons.map(function(person) {
console.log('Currently iterating through person', person.name, 'who is', person.mood);
if (person.mood === 'Excited') {
  person.mood = "Hungry";
}
return person;
});
console.log("result: ", result);
  // ES6
result = persons.map(person => {
console.log('Currently iterating through person', person.name, 'who is', person.mood);
if (person.mood === 'Uncaffeinated') {
  person.mood = "Sleepy";
}
return person;
})
console.log("result 2: ", result);
```

More ES5 stuff [here](https://www.w3schools.com/whatis/whatis_es5.asp)

## Babel

[Babel docs](https://babeljs.io/docs/en/)

- TLDR: Toolchain that converts ES6 into older versions of JS. Ex:

```js
// Babel Input: ES2015 arrow function
[1, 2, 3].map((n) => n + 1);

// Babel Output: ES5 equivalent
[1, 2, 3].map(function(n) {
  return n + 1;
});
```

[See it in action](https://babeljs.io/repl/#?presets=react&code_lz=GYVwdgxgLglg9mABACwKYBt1wBQEpEDeAUIogE6pQhlIA8AJjAG4B8AEhlogO5xnr0AhLQD0jVgG4iAXyJA)

## React

[React](https://reactjs.org/) is a popular JavaScript library for building user interfaces. Its simple core concepts make the library a useful base for building applications for a variety of platforms, including both web and mobile interfaces. Its popularity and widespread adoption have resulted in a large community that has produced libraries and plugins that make working with React a pleasure.

- Components: encapsulate code to smaller isolated pieces, so its more maintainable and dynamic.
- Declarative (efficiently update and render components as data changes)

## Hello World

- Let's make a very simple Hello World React App.

1. Create a index.html file that imports the React and JSX dependecies, and a mina.js file.

2. Run a local http.server with `python3 -m http.server` on that folder's directory

3. Write your code (components) in you main.js file

- This will be very basic so we get a feel for it.

(note that React apps are not usually like this)

[Example](https://github.com/lgc13/LucasCosta_portfolio/tree/master/react/React-Tutorial/Day1/HelloWorld-NoYarn)

## Setup: create-react-app

- create-react-app [(Instructions)](https://github.com/facebook/create-react-app)


2. Run `yarn create react-app your-app-name`

- if you come across an issue like `is not recognized as an internal or external command, operable program or batch file`, then run the following:

```sh
yarn global add create-react-app
create-react-app your-app-name
```

3. Run your app

```sh
cd your-app-name
yarn start
```

- This will run your app on localhost:3000

## First look

- for now, focus attention on public/index.html, src/index.js and src/App.js
- also notice that these files are imported in the src/index.js file

File structure: https://facebook.github.io/create-react-app/docs/folder-structure

1. React

- Allows usage of JSX elements

`import React from 'react';`

2. ReactDom

- Allows us to render through its render()

`import ReactDOM from 'react-dom';`

- ReactDom.render() takes 2 args: itemToBeRendered and locationToRender. Ex:

```js
ReactDOM.render(
  <ComponentName {...props} />,
  document.getElementById('root') // <div id="root"></div>
);
```

## JSX

- Introducing [JSX](https://reactjs.org/docs/introducing-jsx.html)

1. JSK looks like HTML (although its not). Its available by importing from 'react'

2. Optional, not required

 ```js
 // Ex of react without JSK
 React.createElement('h1', /* ... h1 children ... */)
 ```

3. You cannot render more than 1 JSK element next to each other (in the same render return)

4. You CAN however, wrap elements within other elements. Ex: a <div> within another <div>

```js
// Allowed:
render() {
  return (
    <div>
      <h2>Hello world! I am wrapped</h2>
      <h3> I am still wrapper </h3>
    </div>
  )
}

// Not allowed
render() {
  return (
    <h2>Hello world! I am wrapped</h2>
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

## Practice

Let's create an 'About me' small app that uses functional components, and props. This should have hard coded data to display to the user. The data will not be mutable.
