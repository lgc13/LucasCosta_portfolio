QTP Week 2 plans:

- Advise apprentices to start their own wikis (show how/why)

# Day 1

### ES6

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
``` js
const arr = [1, 2, 3];
// Traditional function expression:
const squares = arr.map(function (x) { return x * x });

// With arrow function
const squares = arr.map(x => x * x);

// Arrow function on functions (component)
const HelloEveryone = () => <div><p>How you doin... </p></div>
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
// forEach
persons.forEach(person => console.log(person.name));
// map
let result = persons.map(person => {
  console.log('Currently iterating through person', person.name);
  if (person.mood === 'Excited') {
    person.mood = "Hungry";
  }
  return person;
})
console.log("Array of people hungry: ", result);
// filter
let peopleHungry = result.filter(person => person.mood === "Hungry");
peopleHungry.forEach(person => console.log("Names of people hungry: ", person.name));
```

More ES5 stuff [here](https://www.w3schools.com/whatis/whatis_es5.asp)

### React

[React](https://reactjs.org/) is a popular JavaScript library for building user interfaces. Its simple core concepts make the library a useful base for building applications for a variety of platforms, including both web and mobile interfaces. Its popularity and widespread adoption have resulted in a large community that has produced libraries and plugins that make working with React a pleasure.

- Components: encapsulate code to smaller isolated pieces, so its more maintainable and dynamic.
- Declarative (efficiently update and render components as data changes)

### Setup

- create-react-app [(Instructions)](https://github.com/facebook/create-react-app)

1. Install [Node.js](https://nodejs.org/en/)

2. Install [Yarn](https://yarnpkg.com/latest.msi)

3. Run `yarn create react-app your-app-name`

- if you come across an issue like `is not recognized as an internal or external command, operable program or batch file`, then run the following:

```sh
yarn global add create-react-app
create-react-app your-app-name
```

4. Run your app

```sh
cd your-app-name
yarn start
```

- This will run your app on localhost:3000


### First look

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

### JSX

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

### Components and Props

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




5. Afternoon

- Go over React Todo list
- Some time to tinker
- Reconvene for Q&A and day wrap-up



7. [Babel](https://babeljs.io/repl/#?presets=react&code_lz=GYVwdgxgLglg9mABACwKYBt1wBQEpEDeAUIogE6pQhlIA8AJjAG4B8AEhlogO5xnr0AhLQD0jVgG4iAXyJA)

.... STILL NNED TO TALK ABOUT PROPS

### Props

**** Good for showing a quick JSX => JS breakdown

-----------------

# Day 2

1. [State & Lifecycle](https://reactjs.org/docs/state-and-lifecycle.html)

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
