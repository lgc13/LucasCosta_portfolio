# Day 2

## Styling, Conditional Rendering and Lists

Follow these [instructions](./conditionals-and-lists)

Demo:

![Demo](./conditionals-and-lists/demo.PNG)

## Class Components and State

Follow these [instructions](./class-components-and-state)

Demo:

![Demo](./class-components-and-state/demo.PNG)

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
