# ES6 practice

Demo:

![console-logs-practice](./console-logs-practice.PNG)

Read about it [here](https://codeburst.io/javascript-wtf-is-es6-es8-es-2017-ecmascript-dca859e4821c)

Put simply, ECMAScript is a standard. While JavaScript is the most popular implementation of that standard. JavaScript implements ECMAScript and builds on top of it

[Features of ES6](http://exploringjs.com/es6/ch_overviews.html)

- Let's create a folder with a HTML and JS file, to play around with everything mentioned below.

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
