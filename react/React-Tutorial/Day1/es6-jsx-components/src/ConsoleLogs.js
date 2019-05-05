console.log('>>> for of example:');
const colors = ['red', 'blue', 'green', 'purple'];

for (let color of colors) {
  console.log(color);
}

for (const [index, element] of colors.entries()) {
    console.log(`${index}. ${element}`);
}

console.log('>>> Arrow function example:')
// ES5
var multiplyES5 = function(x, y) {
  return x * y;
};
console.log(multiplyES5(1, 3));

// ES6 (note the curly braces are not required)
const multiplyES6 = (x, y) => { return x * y };
console.log(multiplyES6(5, 6));


console.log('>>> ES5 array manipulation examples: ')
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
