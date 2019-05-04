import React from 'react';
import ReactDOM from 'react-dom';

import './index.css';
import HelloEveryone from './components/HelloEveryone.js'

ReactDOM.render(
  <HelloEveryone />,
  document.getElementById("root")
);
const colors = ['red', 'blue', 'green', 'purple'];

for (let color of colors) {
  console.log(color);
}

for (const [index, element] of colors.entries()) {
    console.log(`${index}. ${element}`);
}

const arr = [1, 2, 3];

// Traditional function expression:
let squares = arr.map(function (x) { return x * x });
console.log(squares);

// with arrow function
squares = arr.map(x => x * x);
console.log(squares);

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
